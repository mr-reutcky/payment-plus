namespace Payment_Plus {
    public abstract class Payment {
        public double Amount { get; protected set; }
        public string Currency { get; protected set; }

        public Payment(double amount, string currency) {
            Amount = amount;
            Currency = currency;
        }

        public abstract void ProcessPayment();
        public virtual bool ValidatePayment() {
            // Rule: No payments ending in .99 (except cash)
            if (Amount % 1 == 0.99) {
                Console.WriteLine($"Invalid Payment: {Amount} {Currency} cannot end in .99");
                return false;
            }
            return true;
        }
        public virtual void LogPayment() {
            Console.WriteLine($"Logging: {GetType().Name} - {Amount} {Currency}");
        }
    }
}
