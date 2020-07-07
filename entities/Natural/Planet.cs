using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Ark.entities.Natural
{
    public class Planet : Desired
    {

        private ICollection<Enum> Parameters { get; set; }
        
        public Planet(string name, ICollection<Enum> parameters)
        {
            this.name = name;
            Parameters = parameters;
        }
        
        public object GetParameterValue(Type value)
        {
            if (Parameters.Count == 0)
                return null;

            return Parameters
                .First(t => t.GetType() == value);
        }
        
    }
}