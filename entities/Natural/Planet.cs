using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Ark.entities.Natural
{
    public sealed class Planet : Desired
    {

        private ICollection<Enum> Parameters { get; set; }
        
        public Planet(string name, ICollection<Enum> parameters)
        {
            this.name = name;
            Parameters = parameters;
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{name}'s stats:\n");
            foreach(var p in Parameters)
            {
                //looks ugly, but werks
                sb.AppendFormat("-{0,-17}\t{1}\n", p.GetType().ToString().Replace("The_Ark.enums.",""), p);
            }
            return sb.ToString();
        }
    }
}