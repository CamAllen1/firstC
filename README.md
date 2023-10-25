# ATM

This is a simple ATM (Automated Teller Machine) system implemented in C#. This project simulates the basic functionalities of an ATM machine, allowing users to check their account balance, withdraw funds, and deposit money.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

1. **User Authentication:** Users are required to provide a valid account number and PIN to access their accounts.

2. **Account Balance Inquiry:** Users can check their account balance.

3. **Cash Withdrawal:** Users can withdraw funds from their account, provided they have a sufficient balance.

4. **Cash Deposit:** Users can deposit money into their account.

5. **Exit:** Allows users to safely exit the application.

## Getting Started

### Prerequisites

- Visual Studio or any C# development environment.
- .NET Framework or .NET Core.

### Installation

1. Clone the repository to your local machine:
   ```
   git clone https://github.com/CamAllen1/EasyATM.git
   ```

2. Open the project in your preferred C# development environment (e.g., Visual Studio).

3. Build the project to compile the code.

## Usage

1. Run the application in your development environment.

2. You will be prompted to enter your account number and PIN.

3. Once authenticated, you can select from the available options (Check Balance, Withdraw, Deposit, Change PIN, or Exit).

4. Follow the on-screen prompts to complete the selected transaction.

5. When you're done, select the "Exit" option to safely close the application.

**Note:** This is a simplified implementation and does not connect to a real banking system. Account data is stored in memory, and PINs are not securely encrypted. For a production-ready ATM system, additional security measures and data persistence are essential.

## Contributing

Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.

2. Create a new branch for your feature or bug fix.

3. Make your changes and commit them.

4. Push your changes to your fork.

5. Submit a pull request to the original repository.

Please ensure your code follows best practices and includes appropriate documentation for new features or changes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

This ATM project is a simple demonstration of a C# application for educational purposes. It does not represent a real banking system and should not be used in a production environment. Use it responsibly and only in a controlled environment.
