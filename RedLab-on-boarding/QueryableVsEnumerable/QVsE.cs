using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedLab_on_boarding.LinqTask;

namespace RedLab_on_boarding.QueryableVsEnumerable
{
    internal class QVsE
    {
        public static void Test()
        { 
            var r = LinqMethod.buyers.AsQueryable().Where(x => x.Id == 3);
            Console.WriteLine(r);

            var d = LinqMethod.shoppings.AsEnumerable().Where(x => x.Id == 3);
            Console.WriteLine(d);
        }
    }
}
