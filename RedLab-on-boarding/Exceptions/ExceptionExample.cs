using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLab_on_boarding.Exceptions
{
    internal static class ExceptionExample
    {
        public static int GetNumber(string number)
        {
            try
            {
                return int.Parse(number);
            }
            catch (ArgumentNullException e)
            {
                return 0;
            }
            catch (Exception e)
            {
                throw new InvalidNumberException(e);
            }
        }
    }
}
