namespace Payment_Plus {
    public abstract class OnlinePayment : Payment {
        public string PaymentGateway { get; protected set; }

        public OnlinePayment(double amount, string currency, string gateway) : base(amount, currency) {
            PaymentGateway = gateway;
        }

        public abstract void Authorize();

        public override bool ValidatePayment() {
            if (!base.ValidatePayment()) return false;
            if (Amount < 5 && (Currency == "CAD" || Currency == "USD") || Amount < 10 && Currency == "EUR") {
                Console.WriteLine($"Invalid Online Payment: {Amount} {Currency} must be at least $5.00 (or €10 for EUR).");
                return false;
            }
            return true;
        }

        public override void ProcessPayment() {
            // Implementation of ProcessPayment method
            Console.WriteLine("Processing online payment...");
        }
    }
}
