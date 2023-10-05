
//Ship items to different destination
//shipping fees are a percentage of given item price
//some places should have additional risk fee $25
//zone 1 25% - zone 2 12%, highRisk - zone 3 8% - zone 4 4%, highRisk
using static Delegate_ex.Shipping;

ShippingFeesDelegate del;
ShippingDestination dest;

//
Console.WriteLine("What is the destination zone?");
string zone = Console.ReadLine();
dest = ShippingDestination.getDestinationInfo(zone);

Console.WriteLine("What is the item price?");
double price = double.Parse(Console.ReadLine());

del = dest.CalcFees;

if (dest._isHighRisk)
{
    del += delegate (double price, ref double fee)
    {
        fee += 25.0;
    };
}

double theFee = 0;
del(price, ref theFee);
Console.WriteLine($"The shipping fees are {theFee}");
