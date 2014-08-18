namespace InheritanceRelationship_01
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string accountNo, string customerName, double serviceCharge): base(accountNo, customerName)
        {
            ServiceCharge = serviceCharge;
        }

        public override string Withdraw(double amount)
        {
            NoOfTransactions++;
            return base.Withdraw(amount);
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " Service Charge: " + ServiceCharge + " No of trasnactions: " + NoOfTransactions;
        }

        public override void Deposit(double amount)
        {
            NoOfTransactions++;
            base.Deposit(amount);
        }

        public double ServiceCharge { set; get; }
        public int NoOfTransactions { private set; get; }
    }
}
