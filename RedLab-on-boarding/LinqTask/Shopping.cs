using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLab_on_boarding.LinqTask
{
    public class Shopping
    {
        public virtual int Id { get;  set; }

        public virtual decimal Summa { get; set; }

        public virtual Buyer Buyer { get; set; }

        public virtual long BuyerId { get; set; }
    }
}
