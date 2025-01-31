namespace Payment_Plus {
    public class BitcoinPayment : OnlinePayment {
        public string WalletID { get; private set; }

        public BitcoinPayment(double amount, string currency, string gateway, string walletID)
            : base(amount, currency, gateway) {
            WalletID = walletID;
        }

        public override void Authorize() {
            Console.WriteLine($"Authorizing Bitcoin Payment via {PaymentGateway} from Wallet {WalletID}");
        }

        public override void ProcessPayment() {
            Console.WriteLine($"Processing Bitcoin Payment: {Amount} {Currency}");
        }
    }
}
