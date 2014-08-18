namespace InheritanceRelationship_01
{
    public class SavingsAccount : Account
    {
        public double InterestAmount { get; set; }
        public SavingsAccount(string accountNo, string customerName, double  interestAmount) : base(accountNo, customerName)
        {
            this.InterestAmount = interestAmount;
        }

        public override sealed void M5()
        {

        }

        public override string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                   return base.Withdraw(amount);
            }
            else
            {
                return "Insuffieient balance";
            }
        }

        // Method hiding
        public new string M1()
        {
            return "return from savings";
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " Interest Rate: " + InterestAmount;
        }
    }
}