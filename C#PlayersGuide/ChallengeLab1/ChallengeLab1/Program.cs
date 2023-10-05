using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ChallengeLab1
{
    internal class Program
    {
       static void Main()
       {

            /*Get user input
             *  purchase price
             *  intrest rate
             *  down payment
             *  market value
             *  term of loan
             *  monthly income
             *  HOA fees
             *Calculate total loan amount
             *Calculate Escrow
            */
            
            Console.WriteLine("Enter home's purchase price: $");
            double purchasePrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter expected down payment from buyer: $");
            double downPayment = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter intrest rate:");
            double intrestRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter market value of home: $");
            double marketValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Term of the loan:");
            double term = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yearly HOA Fees (if any): $");
            double HOAFees = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter buyer's monthly income: $");
            double monthlyIncome = Convert.ToDouble(Console.ReadLine());

            double originationFee = (purchasePrice - downPayment) * 0.01;
            double closingCosts = 0;

            if (downPayment < (marketValue * .01))
            {
                closingCosts = 2500;
            }
          
            double totalLoan = CalculateTotalLoan(purchasePrice, downPayment, originationFee);
            double escrow = CalculateMonthlyEscrow(purchasePrice, HOAFees);
            double monthlyPayment = CalculatePayment(totalLoan, escrow, intrestRate, term, closingCosts);
            Console.WriteLine("Monthly Payment: {0}", monthlyPayment);

       }

        static double CalculateTotalLoan(double purchasePrice, double downPayment, double originationFee)
        {
            return purchasePrice - downPayment + originationFee;
        }

        static double CalculateMonthlyEscrow(double purchasePrice, double HOA)
        {
            double propertyTax = (purchasePrice * 0.0125) / 12;
            double homeInsurance = (purchasePrice * 0.0075) / 12;
            double HOAFees = HOA / 12;

            return propertyTax + homeInsurance + HOAFees;
        }

        static double CalculatePayment(double totalLoan, double escrow, double interest, double term, double closingCost)
        {
            double monthlyIntrest = interest / 12 / 100;
            double baseAmount = (monthlyIntrest * totalLoan) / (1 - Math.Pow(1 + monthlyIntrest, -12));
            return baseAmount + escrow + (closingCost / 12);
                
        }
    }
}

