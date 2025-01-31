namespace Payment_Plus {
    public abstract class OfflinePayment : Payment {
        public OfflinePayment(double amount, string currency) : base(amount, currency) { }

        public abstract void RecordPayment();

        public override bool ValidatePayment() {
            if (!base.ValidatePayment()) return false;
            if (Currency == "EUR") {
                Console.WriteLine($"Invalid Offline Payment: EUR is not accepted.");
                return false;
            }
            return true;
        }
    }
}
