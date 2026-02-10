using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

// test change from github teammate
// final test change
namespace Setup_Project;

class Program
{
    static void Main(string[] args)
    {
        int? x1 = 20;
        int? x2 = null;

        dVal(x1);
        dVal(x2);

        string? s = null;
        Account? accTest = null;


        Account account1 = new Account("Bob", 100);
        Console.WriteLine("Testing Account 1");
        Console.WriteLine(account1.balance);
        account1.balance = 50;
        Console.WriteLine(account1.balance);
        Console.WriteLine(account1.owner);


        Console.WriteLine("Withdrawing 200 from Account 1");
        if (account1.Withdraw(200))
        {
            Console.WriteLine("Success! Displaying new info:");
            account1.Show();
        }
        else
        {
            Console.WriteLine("Insufficient funds. Redisplaying info: ");
            account1.Show();
        }
        Console.WriteLine("Depositing 250 into Account1. Displaying new info:");
        account1.Deposit(250);
        account1.Show();
        Console.WriteLine("Withdrawing 200 from Account 1");
        if (account1.Withdraw(200))
        {
            Console.WriteLine("Success! Displaying new info:");
            account1.Show();
        }
        else
        {
            Console.WriteLine("Insufficient funds. Redisplaying info: ");
            account1.Show();
        }
        Console.WriteLine("Creating Account 2");
        Account account2 = new Account("Mary", 100);
        account2.Show();
        Console.WriteLine("Transferring 100 from Bob to Mary");
        if (account1.Transfer(account2, 100))
        {
            Console.WriteLine("Success! Displaying new info:");
            account1.Show();
            account2.Show();
        }
        else
        {
            Console.WriteLine("Insufficient funds. Redisplaying info:");
            account1.Show();
            account2.Show();
        }
        Console.WriteLine("Transferring 75 from Bob to Mary");
        if (account1.Transfer(account2, 75))
        {
            Console.WriteLine("Success! Displaying new info:");
            account1.Show();
            account2.Show();
        }
        else
        {
            Console.WriteLine("Insufficient funds. Redisplaying info:");
            account1.Show();
            account2.Show();
        }

    }

    static void dVal(int? value)
    {
        if (value.HasValue)
        {
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("parameter does not contain a value");
        }
    }
}
