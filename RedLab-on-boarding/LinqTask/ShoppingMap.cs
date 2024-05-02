using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace RedLab_on_boarding.LinqTask
{
    public class ShoppingMap : ClassMap<Shopping>
    {
        public ShoppingMap()
        {
            Table("Shoppings");

            Id(x => x.Id, "Id").GeneratedBy.Native();

            Map(x => x.Summa, "Summa");

            References(x => x.Buyer).Column("BuyerId");
        }
    }
}
