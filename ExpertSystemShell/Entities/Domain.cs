using System;
using System.Collections.Generic;

namespace ExpertSystemShell.Entities
{
    [Serializable]
    public class Domain
    {
        public string Name { get; set; }
        public List<DomainValue> Values { get; set; }

        public Domain()
        {
            Name = string.Empty;
            Values = new List<DomainValue>();
        }

        public Domain(string name, List<DomainValue> values)
        {
            Name = name;
            Values = values;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
