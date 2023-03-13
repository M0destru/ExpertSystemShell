using ExpertSystemShell.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ExpertSystemShell.Components
{
    public class WorkingMemory
    {
        public Stack<Rule> TriggeredRules { get; }
        public Stack<Fact> ProvenFacts { get; }
        public Stack<Variable> SolvedVariables { get; }

        public WorkingMemory() 
        {
            TriggeredRules = new Stack<Rule>();
            ProvenFacts = new Stack<Fact>();
            SolvedVariables = new Stack<Variable>();
        }

        public bool IsProvenFact(Fact fact)
        {
            return ProvenFacts.FirstOrDefault(provenFact =>
                provenFact.Variable.Name == fact.Variable.Name &&
                provenFact.Value.Value == fact.Value.Value) != null;
        }

        public bool VariableHasValue(Variable var)
        {
            return SolvedVariables.Contains(var);
        }

        public void AddProvenFact(Fact fact)
        {
            ProvenFacts.Push(fact);
            SolvedVariables.Push(fact.Variable);
        }

        public void AddTriggeredRules(Rule rule)
        {
            TriggeredRules.Push(rule);
        }

    }
}
