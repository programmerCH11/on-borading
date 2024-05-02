using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate.Engine;
using NHibernate.Mapping.ByCode.Impl;

namespace RedLab_on_boarding.LinqTask
{
    public class BuyerMap : ClassMap<Buyer>
    {
        public BuyerMap()
        {
            Table("Buyers");

            Id(x => x.Id, "Id").GeneratedBy.Native();

            Map(x => x.Name, "Name");

            HasMany(x => x.Shoppings);
        }
    }
}
