using System;
using System.Collections.Generic;

namespace ExpertSystemShell.Entities
{
    [Serializable]
    public class Rule
    {
        public string Name { get; set; }
        public List<Fact> Premises { get; set; }
        public List<Fact> Inferences { get; set; }
        public string Reason { get; set; }

        public Rule()
        {
            Name = "";
            Premises = new List<Fact>();
            Inferences = new List<Fact>();
            Reason = "";
        }

        public Rule (string name, List<Fact> premises, List<Fact> inferences, string reason)
        {
            Name = name;
            Premises = premises;
            Inferences = inferences;
            Reason = reason;
        }

        public bool ContainsFact(Fact fact)
        {
            return Premises.Exists(r => r.Variable.Name == fact.Variable.Name && r.Value.Value == fact.Value.Value) || 
                Inferences.Exists(r => r.Variable.Name == fact.Variable.Name && r.Value.Value == fact.Value.Value);
        }

        public bool ContainsVariableInInference(Variable var)
        {
            return Inferences.Exists(r => r.Variable == var);
        }

        public override string ToString()
        {
            return $"ЕСЛИ {string.Join(" И ", Premises)} ТО {string.Join(" И ", Inferences)}";
        }
    }
}
