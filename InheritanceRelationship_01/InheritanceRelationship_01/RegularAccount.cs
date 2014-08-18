using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationship_01
{
    class RegularAccount : Account
    {
        public double DailyTransactionAmount { set; get; }

        public RegularAccount(string accountNo, string customerName) : base(accountNo, customerName)
        {

        }

        public override string GetInfo()
        {
            return base.GetInfo() + "Daily Tx: " + DailyTransactionAmount;
        }
    }
}
