using ExpertSystemShell.Entities;
using ExpertSystemShell.UI;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpertSystemShell.Components
{
    public class InferenceEngine
    {
        public Variable ConsultationGoal { get; }
        public KnowledgeBase KnowledgeBase { get; }
        public WorkingMemory WorkingMemory { get; }
        private readonly List<Rule> _proccesingRules;
        private bool outputInterrupted;

        public InferenceEngine(KnowledgeBase knowledgeBase)
        {
            KnowledgeBase = knowledgeBase;
            WorkingMemory = new WorkingMemory();
            _proccesingRules = new List<Rule>();
        }

        private List<Rule> GetConflictRuleList(Variable goal)
        {
            return KnowledgeBase.Rules
                .Where(r => r.ContainsVariableInInference(goal) && !_proccesingRules.Contains(r))
                .ToList();
        }

        private bool TryProveGoal(Rule rule)
        {
            foreach (var fact in rule.Premises)
            {
                bool varHasValue = RunReverseOutput(fact.Variable);
                if (!varHasValue || !WorkingMemory.IsProvenFact(fact))
                {
                    return false;
                }
            }
            // добавить факт в список выведенных фактов и правило в список сработавших правил
            rule.Inferences.ForEach(f => WorkingMemory.AddProvenFact(f));
            WorkingMemory.AddTriggeredRules(rule);
            return true;
        }

        private bool AskQuestion(Variable goal)
        {
            ConsultationForm consForm = new ConsultationForm(WorkingMemory, goal);
            DialogResult dlgResult = consForm.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                WorkingMemory.AddProvenFact(consForm.RequestedFact);
            }
            else
            {
                outputInterrupted = true;
            }
            return !outputInterrupted;
        }

        private bool RunReverseOutput(Variable goal)
        {
            if (WorkingMemory.VariableHasValue(goal))
            {
                return true;
            }
            else if (goal.Type == EVariableType.Requested)
            {
                return AskQuestion(goal);           
            }

            List<Rule> conflictRuleLst = GetConflictRuleList(goal);
            foreach (var rule in conflictRuleLst) 
            {
                _proccesingRules.Add(rule);
                bool goalProved = TryProveGoal(rule);
                _proccesingRules.Remove(rule);
                if (goalProved)
                {
                    return true;
                }
                else if (outputInterrupted)
                {
                    return false;
                }
            }

            // выводимо-запрашиваемая переменная не означена -> запрос у пользователя
            if (goal.Type == EVariableType.InferredRequested)
            {
                return AskQuestion(goal);
            }

            return false;
        }

        public bool Run(Variable ConsultationGoal)
        {
            outputInterrupted = false;
            return RunReverseOutput(ConsultationGoal);
        }
    }
}
