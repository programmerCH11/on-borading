using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLab_on_boarding.LinqTask
{
    internal class LinqMethod
    {
        #region EntityInitialization

        public static IList<Buyer> buyers = new List<Buyer>()
        {
            new Buyer()
            {
                Id = 1,
                Name = "John",
            },
            new Buyer()
            {
                Id = 2,
                Name = "Dave"
            },
            new Buyer()
            {
                Id = 3,
                Name = "Ban"
            }
        };
        public static IList<Shopping> shoppings = new List<Shopping>()
        {
            new Shopping()
            {
                BuyerId = 1,
                Id = 1,
                Summa = 1400
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 2,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 3,
                Id = 3,
                Summa = 1500
            },
            new Shopping()
            {
                BuyerId = 1,
                Id = 4,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 1,
                Id = 5,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 6,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 1,
                Id = 7,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 1,
                Id = 8,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 9,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 1,
                Id = 10,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 11,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 12,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 13,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 14,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 15,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 16,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 17,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 18,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 19,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 20,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 21,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 22,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 23,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 24,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 25,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 26,
                Summa = 100
            },
            new Shopping()
            {
                BuyerId = 2,
                Id = 26,
                Summa = 100
            },
        };

        #endregion

        public static string GetBestBuyer()
        {
            return buyers
                .Join(shoppings, x => x.Id, y => y.BuyerId,
                    (b, s) => new { BuyerId = s.BuyerId, Name = b.Name, Sum = s.Summa })
                .GroupBy(x => x.BuyerId)
                .OrderByDescending(x => x.Sum(d => d.Sum))
                .First().First()
                .Name;
        }
    }
}
