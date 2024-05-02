using RedLab_on_boarding.LinqTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Criterion;

namespace RedLab_on_boarding.QueryOverTask
{
    internal class BuyersQueryOver
    {
        public static string GetBestBuyer()
        {

            var s2 = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString("Data Source=localhost;Initial Catalog=NHibernateBasics; Integrated Security=True")).Mappings(x => x.FluentMappings.AddFromAssemblyOf<Program>())
                .BuildSessionFactory().OpenSession();

            Buyer buyerAlias = null;
            Shopping shoppingAlias = null;

            var data = s2.QueryOver<Buyer>(() => buyerAlias)
                .JoinAlias(() => buyerAlias.Shoppings, () => shoppingAlias)
                .Select(
                    Projections.Group(() => buyerAlias.Id).As("Id"),
                    Projections.Group(() => buyerAlias.Name).As("Name"), // Group by BuyerId
                    Projections.Sum(() => shoppingAlias.Summa).As("Summa") // Calculate the sum of Summa
                )
                .OrderBy(Projections.Sum(() => shoppingAlias.Summa)).Desc // Order by sum in descending order
                .Take(1) // Take the top result (best buyer)
                .List<object[]>();

            return (string)data[0][1];
        }
    }
}
