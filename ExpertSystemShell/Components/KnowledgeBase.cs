using ExpertSystemShell.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExpertSystemShell.Components
{

    [Serializable]
    public class KnowledgeBase
    {
        public List<Rule> Rules { get; set; }
        public List<Variable> Variables { get; set; }
        public BindingList<Domain> Domains { get; set; }

        public KnowledgeBase() 
        {
            Rules = new List<Rule>();
            Variables = new List<Variable>();
            Domains = new BindingList<Domain>();
        }

        public KnowledgeBase(List<Rule> rules, List<Variable> variables, BindingList<Domain> domains)
        {
            Rules = rules;
            Variables = variables;
            Domains = domains;
        }

        public KnowledgeBase LoadKnowledgeBase(string pathToFile)
        {
            KnowledgeBase data;
            using (FileStream fs = new FileStream(pathToFile, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                data = (KnowledgeBase) binaryFormatter.Deserialize(fs);
            }
            return data;
        }

        public void SaveKnowledgeBase(string pathToFile)
        {
            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, this);
            }
        }

        public bool FactUsed(Fact fact)
        {
            foreach (var rule in Rules)
            {
                if (rule.Premises.Contains(fact) || rule.Inferences.Contains(fact))
                {
                    return true;
                }
            }
            return false;
        }

        public EditRuleResult AddRule(Rule newRule, int position)
        {
            if (string.IsNullOrWhiteSpace(newRule.Name))
            {
                return EditRuleResult.EmptyName;
            }

            if (Rules.Exists(d => d.Name == newRule.Name))
            {
                return EditRuleResult.AlreadyExistsName;
            }

            if (newRule.Premises.Count == 0)
            {
                return EditRuleResult.EmptyPremiseList;
            }

            if (newRule.Inferences.Count == 0)
            {
                return EditRuleResult.EmptyInferenceList;
            }

            Rules.Insert(position + 1, newRule);
            return EditRuleResult.Success;
        }

        public EditRuleResult ChangeRule(Rule oldRule, Rule newRule)
        {
            if (string.IsNullOrWhiteSpace(newRule.Name))
            {
                return EditRuleResult.EmptyName;
            }

            if (oldRule.Name != newRule.Name && Rules.Exists(d => d.Name == newRule.Name))
            {
                return EditRuleResult.AlreadyExistsName;
            }

            if (newRule.Premises.Count == 0)
            {
                return EditRuleResult.EmptyPremiseList;
            }

            if (newRule.Inferences.Count == 0)
            {
                return EditRuleResult.EmptyInferenceList;
            }

            Rules[Rules.IndexOf(oldRule)] = newRule;
            return EditRuleResult.Success;
        }

        public EditRuleResult DeleteRule(Rule rule)
        {
            Rules.Remove(rule);
            return EditRuleResult.Success;
        }

        public List<Rule> GetRulesWithVariable(Variable variable)
        {
            return Rules.FindAll(r =>
                r.Premises.Exists(f => f.Variable == variable) ||
                r.Inferences.Exists(f => f.Variable == variable)).ToList();
        }

        public List<Rule> GetRulesWithDomain(Domain domain)
        {
            return Rules.FindAll(r =>
                r.Premises.Exists(f => f.Variable.Domain == domain) ||
                r.Inferences.Exists(f => f.Variable.Domain == domain)).ToList();
        }

        public List<Variable> GetVariablesWithDomain(Domain domain)
        {
            return Variables.Where(v => v.Domain == domain).ToList();
        }

        public bool VariableUsed(Variable variable)
        {
            return Rules.Exists(r =>
                r.Premises.Exists(f => f.Variable == variable) ||
                r.Inferences.Exists(f => f.Variable == variable));
        }

        public EditVariableResult AddVariable(Variable newVariable, int position)
        {
            if (string.IsNullOrWhiteSpace(newVariable.Name))
            {
                return EditVariableResult.EmptyName;
            }

            if (Variables.Exists(v => v.Name == newVariable.Name))
            {
                return EditVariableResult.AlreadyExistsName;
            }

            if (newVariable.Domain == null)
            {
                return EditVariableResult.EmptyDomain;
            }

            if (newVariable.Type != EVariableType.Inferable && 
                string.IsNullOrWhiteSpace(newVariable.Question))
            {
                return EditVariableResult.EmptyQuestion;
            }

            Variables.Insert(position + 1, newVariable);
            return EditVariableResult.Success;
        }

        public EditVariableResult ChangeVariable(Variable oldVariable, Variable newVariable) 
        {
            if (string.IsNullOrWhiteSpace(newVariable.Name))
            {
                return EditVariableResult.EmptyName;
            }

            if (oldVariable.Name != newVariable.Name && 
                Variables.Exists(v => v.Name == newVariable.Name))
            {
                return EditVariableResult.AlreadyExistsName;
            }

            if (newVariable.Domain == null)
            {
                return EditVariableResult.EmptyDomain;
            }

            if (newVariable.Type != EVariableType.Inferable &&
                string.IsNullOrWhiteSpace(newVariable.Question))
            {
                return EditVariableResult.EmptyQuestion;
            }

            if (VariableUsed(oldVariable))
            {
                if (oldVariable.Type != newVariable.Type || oldVariable.Domain != newVariable.Domain)
                {
                    return EditVariableResult.VariableUsed;
                }
            }

            Variables[Variables.IndexOf(oldVariable)] = newVariable;
            foreach (var rule in Rules)
            {
                foreach (var fact in rule.Premises.Union(rule.Inferences))
                {
                    if (fact.Variable == oldVariable)
                    {
                        fact.Variable = newVariable;
                    }
                }
            }
            return EditVariableResult.Success;
        }

        public EditVariableResult DeleteVariable(Variable variable)
        {
            if (VariableUsed(variable))
            {
                return EditVariableResult.VariableUsed;
            }

            Variables.Remove(variable);
            return EditVariableResult.Success;
        }

        public bool DomainUsedInRules(Domain domain)
        {
            Variable varWithDomain = Variables.FirstOrDefault(v => v.Domain == domain);
            return varWithDomain != null && VariableUsed(varWithDomain);
        }

        public bool DomainUsedInVariables(Domain domain)
        {
            return Variables.Exists(v => v.Domain == domain);
        }

        public EditDomainResult AddDomain(Domain newDomain, int position)
        {
            if (string.IsNullOrWhiteSpace(newDomain.Name))
            {
                return EditDomainResult.EmptyName;
            }
            if (Domains.FirstOrDefault(d => d.Name == newDomain.Name) != null)
            {
                return EditDomainResult.AlreadyExistsName;
            }
            if (newDomain.Values.Count == 0)
            {
                return EditDomainResult.EmptyDomainValues;
            }

            Domains.Insert(position + 1, newDomain);
            return EditDomainResult.Success;
        }

        public EditDomainResult ChangeDomain(Domain oldDomain, Domain newDomain)
        {
            if (string.IsNullOrWhiteSpace(newDomain.Name))
            {
                return EditDomainResult.EmptyName;
            }
            if (oldDomain.Name != newDomain.Name && 
                Domains.FirstOrDefault(d => d.Name == newDomain.Name) != null)
            {
                return EditDomainResult.AlreadyExistsName;
            }
            if (newDomain.Values.Count == 0)
            {
                return EditDomainResult.EmptyDomainValues;
            }

            if (DomainUsedInVariables(oldDomain))
            {
                if (!oldDomain.Values.All(oldDv => newDomain.Values.Exists(newDv => oldDv.Value == newDv.Value)))
                {
                    return EditDomainResult.DomainUsed;
                }
            }

            Domains[Domains.IndexOf(oldDomain)] = newDomain;
            foreach (var variable in Variables)
            {
                if (variable.Domain == oldDomain)
                {
                    variable.Domain = newDomain;
                }
            }
            return EditDomainResult.Success;
        }
        
        public EditDomainResult DeleteDomain(Domain domain)
        {
            if (DomainUsedInVariables(domain)) 
            {
                return EditDomainResult.DomainUsed;
            }

            Domains.Remove(domain);
            return EditDomainResult.Success;
        }

    }
}
