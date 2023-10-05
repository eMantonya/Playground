using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_ex
{
    public class Shipping
    {
        //declare the delegate type used to calc fees
        public delegate void ShippingFeesDelegate(double price, ref double fee);

        //This is a base class that is used as a foundation for each of the destination zones
        public abstract class ShippingDestination 
        {
            public bool _isHighRisk;
            public virtual void CalcFees(double price, ref double fee) { }
            
            //this static method returns an actual ShippingDestination object given the name of the destination, or null if none exist
            public static ShippingDestination getDestinationInfo(string dest)
            {
                if (dest == "zone1") { return new Dest_Zone1(); }
                if (dest == "zone2") { return new Dest_Zone2(); }
                if (dest == "zone3") { return new Dest_Zone3(); }
                if (dest == "zone4") { return new Dest_Zone4(); }
                return null;
            }

        }

        class Dest_Zone1 : ShippingDestination
        {
            public Dest_Zone1()
            {
                this._isHighRisk = false;
            }
            public override void CalcFees(double price, ref double fee)
            {
                fee = price * 0.25;
            }
        }
        class Dest_Zone2 : ShippingDestination
        {
            public Dest_Zone2()
            {
                this._isHighRisk = true;
            }
            public override void CalcFees(double price, ref double fee)
            {
                fee = price * 0.12;
            }
        }
        class Dest_Zone3 : ShippingDestination
        {
            public Dest_Zone3()
            {
                this._isHighRisk = false;
            }
            public override void CalcFees(double price, ref double fee)
            {
                fee = price * 0.08;
            }
        }
        class Dest_Zone4 : ShippingDestination
        {
            public Dest_Zone4()
            {
                this._isHighRisk = true;
            }
            public override void CalcFees(double price, ref double fee)
            {
                fee = price * 0.04;
            }
        }

    }
}
