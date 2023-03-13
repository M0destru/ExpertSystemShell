using System;

namespace ExpertSystemShell.Entities
{
    [Serializable]
    public class DomainValue
    {
        public string Value { get; }

        public DomainValue(string value) 
        {
            Value = value;
        }

        public override string ToString() { return Value; }
    }
}
