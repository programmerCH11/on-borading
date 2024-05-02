using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLab_on_boarding.Delegates
{
    internal class DelegatesMethods
    {
        public delegate IEnumerable<int> ProcessNumbers(IEnumerable<int> numbers);

        public static IEnumerable<int> GetInfinityNumberList()
        {
            var number = 1;

            while (true)
            {
                yield return number++;
            }
        }

        public static IEnumerable<int> GetEvenNumbers(IEnumerable<int> sourceNumbers)
        {
            return sourceNumbers.Where(x => x % 2 == 0);
        }

        public static IEnumerable<int> ThirdMethod(ProcessNumbers processNumbers)
        {
            return processNumbers.Invoke(GetInfinityNumberList());
        }
    }
}
