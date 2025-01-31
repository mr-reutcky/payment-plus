namespace Payment_Plus {
    internal class Program {
        static void Main(string[] args) {
            // Step 1: Create a Payment Manager instance to manage all payment transactions.
            PaymentManager manager = new PaymentManager();

            // ------------------------- Valid Payments -------------------------
            // 1. A valid credit card payment of $20 CAD processed through Stripe.
            manager.AddPayment(new CreditCardPayment(20, "CAD", "Stripe", "1234-5678-9101-1121", "12/25", "123"));

            // 2. A valid Bitcoin payment of $15 USD processed through Coinbase.
            manager.AddPayment(new BitcoinPayment(15, "USD", "Coinbase", "wallet123"));

            // 3. A valid cash payment of $10.50 USD (Cash payments allow any decimal values).
            manager.AddPayment(new CashPayment(10.50, "USD"));

            // 4. A valid cheque payment of $100 USD (USD cheques must be in whole-dollar amounts).
            manager.AddPayment(new ChequePayment(100, "USD", "CH123", "Bank ABC"));


            // --- Invalid Payments (These will be removed during validation) ---
            // 6. A credit card payment of $4 CAD (Invalid: Below the $5 minimum for CAD).
            manager.AddPayment(new CreditCardPayment(4, "CAD", "Stripe", "5678-1234-9101-1121", "11/26", "456"));

            // 7. A Bitcoin payment of €4.99 EUR (Invalid: Below the €5 minimum for online payments).
            manager.AddPayment(new BitcoinPayment(4.99, "EUR", "PayPal", "wallet456"));

            // 8. A cheque payment of $6.75 USD (Invalid: USD cheques must be in whole-dollar amounts).
            manager.AddPayment(new ChequePayment(6.75, "USD", "CH999", "Bank XYZ"));

            // 9. A cheque payment of €20 EUR (Invalid: EUR is not accepted for offline payments).
            manager.AddPayment(new ChequePayment(20, "EUR", "CH777", "Bank Euro"));


            // Step 3: Validate all payments.
            // - This will check each payment against the business rules.
            // - Invalid payments will be removed from the payment list.
            manager.ValidatePayments();

            // Step 4: Authorize all online payments.
            // - This will attempt to authorize credit card and bitcoin payments.
            // - Offline payments (cash and cheque) do not require authorization.
            manager.AuthorizePayments();

            // Step 5: Record all offline payments.
            // - Cash and cheque payments are recorded in the system.
            // - Online payments (credit card and bitcoin) do not require this step.
            manager.RecordOffline();

            // Step 6: Process all remaining valid payments.
            // - After validation, authorization, and recording, payments are finalized.
            manager.ProcessPayments();

            /*-------------------------------------------------------------------------------------------------------------------*/

            // Logging all payments (For testing)
            manager.DisplayPayments();
        }
    }
}
