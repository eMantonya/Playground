PiggyBank pb = new PiggyBank();
BalanceLogger bl = new BalanceLogger();
BalanceWatcher bw = new BalanceWatcher();

pb.balanceChanged += bl.balanceLog;
pb.balanceChanged += bw.balanceWatch;

string str;
do
{
    Console.WriteLine("How much to deposit?");
    str = Console.ReadLine();
    if (str != "exit")
    {
        double newValue = double.Parse(str);
        pb.balance += newValue;
    }
} while (str != "exit");



public delegate void BalanceEventHandler(double value);

class PiggyBank
{
    private double _bankBalance;
    public event BalanceEventHandler balanceChanged;

    public double balance
    {
        set
        {
            _bankBalance = value;
            balanceChanged(value);
        }
        get
        {
            return _bankBalance;
        }
    }
}

class BalanceLogger
{
    public void balanceLog(double amount)
    {
        Console.WriteLine($"The balance amount is {amount}");
    }
}

class BalanceWatcher
{
    public void balanceWatch(double amount)
    {
        if (amount > 500)
        {
            Console.WriteLine($"You have reached your savings goal! You have {amount} saved.");
        }
    }
}
