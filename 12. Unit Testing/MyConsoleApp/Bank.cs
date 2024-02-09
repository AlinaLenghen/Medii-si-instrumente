namespace Bank
{
    public class Account
    {
        public string CustomerName { get; private set; }
        public decimal Balance { get; private set; }

        // Constructor
        public Account(string customerName, decimal initialBalance)
        {
            CustomerName = customerName;
            Balance = initialBalance;
        }

        public void Debit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be negative.");
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            Balance -= amount;
        }

        public void Credit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be negative.");
            }

            Balance += amount;
        }
    }
}