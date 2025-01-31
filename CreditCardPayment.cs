namespace Payment_Plus {
    public class CreditCardPayment : OnlinePayment {
        public string CardNumber { get; private set; }
        public string ExpiryDate { get; private set; }
        public string CVV { get; private set; }

        public CreditCardPayment(double amount, string currency, string gateway, string cardNumber, string expiryDate, string cvv)
            : base(amount, currency, gateway) {
            CardNumber = cardNumber;
            ExpiryDate = expiryDate;
            CVV = cvv;
        }

        public override void Authorize() {
            Console.WriteLine($"Authorizing Credit Card Payment via {PaymentGateway} for {Amount} {Currency}");
        }

        public override void ProcessPayment() {
            Console.WriteLine($"Processing Credit Card Payment: {Amount} {Currency}");
        }
    }
}
