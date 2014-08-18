namespace InheritanceRelationship_01
{
    public class Account
    {
        public Account(string accountNo, string customerName) : this()
        {
            AccountNumber = accountNo;
            CustomerName = customerName;
        }

        public virtual void M5()
        {

        }

        public Account()
        {
            Balance = 0;
        }

        public string AccountNumber { set; get; }
        public string CustomerName { set; get; }
        public double Balance { private set; get; }

        public string M1()
        {
            return "M1...";
        }

        public virtual string GetInfo()
        {
            return "Account no :" + AccountNumber + " Balance: " + Balance;
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "withdrawn";
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
