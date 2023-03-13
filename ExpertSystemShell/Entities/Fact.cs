using System;

namespace ExpertSystemShell.Entities
{
    [Serializable]
    public class Fact
    {
        public Variable Variable { get; set; }
        public DomainValue Value { get; set; }

        public Fact (Variable variable, DomainValue value)
        {
            Variable = variable;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Variable} = {Value}";
        }
    }
}
