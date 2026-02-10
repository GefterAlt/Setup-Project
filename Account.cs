using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

namespace Setup_Project;

class Account
{
    private float _balance;

    public float balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    public string owner
    {
        get;
    }

    public Account(string o, float b)
    {
        owner = o;
        _balance = b;
    }

    public float GetBalance()
    {
        return balance;
    }

    public void Deposit(float amt)
    {
        balance += amt;
    }

    public bool Withdraw(float amt)
    {
        if (amt <= balance)
        {
            balance -= amt;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Transfer(Account other, float amt)
    {
        if (amt <= balance)
        {
            balance -= amt;
            other.Deposit(amt);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Show()
    {
        Console.WriteLine($"Owner: {owner}, Balance: {balance}");
        Console.WriteLine("testing");
        Console.WriteLine("testing 2");
    }

}
