namespace Payment_Plus {
    public class PaymentManager {
        private List<Payment> payments = new List<Payment>();

        public void AddPayment(Payment payment) {
            payments.Add(payment);
        }

        public void ValidatePayments() {
            for (int i = payments.Count - 1; i >= 0; i--) {
                if (!payments[i].ValidatePayment()) {
                    Console.WriteLine($"Removing Invalid Payment: {payments[i].GetType().Name} - {payments[i].Amount} {payments[i].Currency}\n");
                    payments.RemoveAt(i);
                }
            }
        }

        public void AuthorizePayments() {
            foreach (Payment payment in payments) {
                if (payment is OnlinePayment onlinePayment)
                    onlinePayment.Authorize();
            }
        }

        public void RecordOffline() {
            foreach (Payment payment in payments) {
                if (payment is OfflinePayment offlinePayment)
                    offlinePayment.RecordPayment();
            }
        }

        public void ProcessPayments() {
            foreach (Payment payment in payments) {
                payment.ProcessPayment();
            }
        }

        // Only used for testing
        public void DisplayPayments() {
            foreach (Payment payment in payments) {
                payment.LogPayment();
            }
        }
    }
}
