namespace Payment_Plus {
    public class ChequePayment : OfflinePayment {
        public string ChequeNumber { get; private set; }
        public string BankName { get; private set; }

        public ChequePayment(double amount, string currency, string chequeNumber, string bankName)
            : base(amount, currency) {
            ChequeNumber = chequeNumber;
            BankName = bankName;
        }

        public override void RecordPayment() {
            Console.WriteLine($"Recording Cheque Payment: {Amount} {Currency}, Cheque #{ChequeNumber}, Bank: {BankName}");
        }

        public override void ProcessPayment() {
            Console.WriteLine($"Processing Cheque Payment: {Amount} {Currency}");
        }

        public override bool ValidatePayment() {
            if (!base.ValidatePayment()) return false;
            if (Currency == "USD" && Amount % 1 != 0) {
                Console.WriteLine($"Invalid Cheque Payment: USD cheques must be whole dollar amounts.");
                return false;
            }
            return true;
        }
    }
}
