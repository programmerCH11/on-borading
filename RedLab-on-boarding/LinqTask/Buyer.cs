using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping;
using NHibernate.Mapping.ByCode.Impl;

namespace RedLab_on_boarding.LinqTask
{
    public class Buyer
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Shopping> Shoppings { get; set; }
    }
}
