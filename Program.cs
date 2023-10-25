using System;

public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public string getNum()
    {
        return cardNum;
    }
    public string getPin()
    {
        return pin;
    }
    public string getFirstName()
    {
        return firstName;
    }
    public string getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }

    public void setNum(string newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(string[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from the following...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Show Balance");
            Consolo.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money you would like to deposit: ");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for your $. Your balance is: " + currentUser.getBalance());
        }

        void withdrawal(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdrawal: ");
            double withdrawal = double.Parse(Console.ReadLine());
            if (currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("Insufficient funds :(");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You are good to go! Thank you!");
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current Balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4024007164547928", 1234, "Sallie", "Mae", 100.50));
        cardHolders.Add(new cardHolder("4024007123968140", 4321, "Ashley", "Johnson", 423.50));
        cardHolders.Add(new cardHolder("4485747963586138", 9999, "Neal", "Lincoln", 105.59));
        cardHolders.Add(new cardHolder("4024007181241323", 2222, "Keith", "Cozart", 527.64));
        cardHolders.Add(new cardHolder("4532717831052616", 4444, "Dawn", "Soap", 54.27));

        Console.WriteLine("Welcome to EasyATM");
        Console.WriteLine("Please insert debit card: ");
        string debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolder.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized. Please try again"); }
            }
            catch { Console.WriteLine("Card not recognized. Please try again"); }
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;

        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect Pin! Please try again!"); }
            }
            catch { Console.WriteLine("Incorrect Pin! Please try again!"); }
        }

        Console.WriteLine("Welcome " + currrentUser.getFirstName());
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdrawal(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);
        Console.WriteLine("Thank you! Have a nice day!");
    }
}


