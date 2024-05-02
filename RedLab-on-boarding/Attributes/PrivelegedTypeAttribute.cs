using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLab_on_boarding.Attributes
{
    internal class PrivilegedTypeAttribute : Attribute
    {
        public string Prefix { get; set; }

        public PrivilegedTypeAttribute(string prefix)
        {
            Prefix = prefix;
        }
    }
}
