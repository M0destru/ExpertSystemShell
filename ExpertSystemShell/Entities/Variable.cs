using System;

namespace ExpertSystemShell.Entities
{
    public enum EVariableType
    {
        Requested,
        Inferable,
        InferredRequested,
    }

    [Serializable]
    public class Variable
    {
        public string Name { get; set; }
        public EVariableType Type { get; set; }
        public Domain Domain { get; set; }
        public string Question { get; set; }

        public Variable()
        {

        }

        public Variable(string name, EVariableType type, Domain domain, string question)
        {
            Name = name;
            Type = type;
            Domain = domain;
            Question = question;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
