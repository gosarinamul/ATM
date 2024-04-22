using System;

public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getCardNum()
    {
        return cardNum;
    }

    public int getPin() { 
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }
    public String getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }
    public void SetBalance(double balance)
    {
        this.balance = balance;
    }
    public void setCardNum(String cardNum)
    {
        this.cardNum = cardNum;
    }
    public void setPin(int pin)
    {
        this.pin = pin;
    }
    public void setFirstName(String firstName)
    {
        this.firstName = firstName;
    }
    public void setLastName(String lastName)
    {
        this.lastName = lastName;
    }
    
    public static void Main(String[] args)
    {
        void printOption()
        {
            Console.WriteLine("Please choose from one of the following otptions..");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Show balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much would you like to deposit today? :");
            double deposit = Double.Parse(Console.ReadLine());
            double userBalance = currentUser.getBalance();
            double newUserBalance = userBalance + deposit;
            currentUser.SetBalance(newUserBalance);
            Console.WriteLine(deposit+" has been deposit. The new balance is " + currentUser.getBalance());
        }

        void withdrwal(cardHolder currentUser)
        {
            Console.WriteLine("How much would you like to withdrawal today? :");
            double withdrawal = Double.Parse(Console.ReadLine());
            double userBalance = currentUser.getBalance();
            if (withdrawal < 0 || userBalance < withdrawal)
            {
                Console.WriteLine("You cannot withdrawal more money than you have. Try again.");
            }
            else {
                double newUserbalance = userBalance - withdrawal;
                currentUser.SetBalance(newUserbalance);
                Console.WriteLine(withdrawal + " has been withdrawal. The new balance is " + currentUser.getBalance());
            }
        }

        void showBalance(cardHolder currentUser)
        {
            Console.WriteLine("Hi. Your balance is " + currentUser.getBalance());
        }

        void exit(cardHolder currentUser, double deposit)
        {
            Console.WriteLine("Thank you. Come again");
        }

        // sort of db
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("12344", 0, "John", "Smith", 150.00));
        cardHolders.Add(new cardHolder("22465", 0, "Sarah", "Martine", 451.50));
        cardHolders.Add(new cardHolder("45646", 0, "Suzanne", "Jones", 100.00));
        cardHolders.Add(new cardHolder("75423", 0, "Marie", "Park", 5051.00));
        cardHolders.Add(new cardHolder("98744", 0, "Alex", "Doe", 50.00));

        // Prompt user
        Console.WriteLine("Welcome to ATM");
        Console.WriteLine("Please inset your debit card number : ");
        String debitCardNum = "";
        cardHolder current;


    } 
}