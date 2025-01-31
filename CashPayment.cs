namespace Payment_Plus {
    public class CashPayment : OfflinePayment{
        public CashPayment(double amount, string currency) : base(amount, currency) { }

        public override void RecordPayment() {
            Console.WriteLine($"Recording Cash Payment: {Amount} {Currency}");
        }

        public override void ProcessPayment() {
            Console.WriteLine($"Processing Cash Payment: {Amount} {Currency}");
        }
    }
}
