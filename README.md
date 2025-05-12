# Payment Plus

**Payment Plus** is a C# application that demonstrates a modular and extensible approach to handling various payment methods. It showcases object-oriented programming principles such as inheritance and polymorphism, making it an excellent resource for learning and extending payment processing functionalities.

## Features

- **Modular Payment Methods**: Supports multiple payment types, including:
  - Cash
  - Cheque
  - Credit Card
  - Bitcoin
  - Online Payments
  - Offline Payments

- **Extensible Architecture**: Easily add new payment methods by extending the base `Payment` class.

- **Centralized Management**: Utilize the `PaymentManager` class to process and manage different payment types seamlessly.

## Project Structure

```
payment-plus/
├── Payment Plus.sln
├── Payment Plus.csproj
├── Program.cs
├── Payment.cs
├── PaymentManager.cs
├── CashPayment.cs
├── ChequePayment.cs
├── CreditCardPayment.cs
├── BitcoinPayment.cs
├── OnlinePayment.cs
├── OfflinePayment.cs
├── obj/
└── bin/
```

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Running the Application

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/mr-reutcky/payment-plus.git
   cd payment-plus
   ```

2. **Build the Solution**:

   ```bash
   dotnet build
   ```

3. **Run the Application**:

   ```bash
   dotnet run
   ```

## Usage

The application demonstrates processing various payment methods. Each payment type is implemented as a class inheriting from the base `Payment` class. The `PaymentManager` class manages the processing of these payments.

Example usage:

```csharp
PaymentManager paymentManager = new PaymentManager();

CashPayment cashPayment = new CashPayment(100.00m);
paymentManager.ProcessPayment(cashPayment);

CreditCardPayment creditCardPayment = new CreditCardPayment("1234-5678-9012-3456", 250.00m);
paymentManager.ProcessPayment(creditCardPayment);
```

## Contributing

Contributions are welcome! If you'd like to add new features or improve existing ones, please fork the repository and submit a pull request.

## License

This project is open-source and available under the [MIT License](LICENSE).
