using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RedLab_on_boarding.Attributes
{
    internal class BaseType
    {
        public override string ToString()
        {
            return this.GetType()
                       .GetCustomAttribute(typeof(PrivilegedTypeAttribute), false) is PrivilegedTypeAttribute privilegedTypeAttribute 
                ? $"Privileged type: {privilegedTypeAttribute.Prefix}" 
                : "Simple type";
        }
    }
}
