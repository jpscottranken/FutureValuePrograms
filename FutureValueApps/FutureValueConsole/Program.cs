using System;
using static System.Console;

/*
 *      This is a C# console program that will let the user
 *      create a future value, based on the following:
 *      
 *      monthly investment      -   Must be between 1000 and 1000000
 *      yearly interest rate    -   Must be between 1% (0.01) and 10% (0.1)
 *      number of years         -   Must be between 10 and 25
 */

namespace FutureValueConsole
{
    internal class Program
    {
        //  Global constants
        const decimal MINMONTHLYINVESTMENT  =    1000.00M;
        const decimal MAXMONTHLYINVESTMENT  = 1000000.00M;
        const decimal MINYEARLYINTERESTRATE =       1.00M;
        const decimal MAXYEARLYINTERESTRATE =      10.00M;
        const int     MINNUMBEROFYEARS      =      10;
        const int     MAXNUMBEROFYEARS      =      25;
        const string  errMsg0               = "  Please try again.";
        const string  errMsg1               = "Monthly Investment Must Be Numeric.";
        const string  errMsg2               = "Monthly Investment Out-Of-Range.";
        const string  errMsg3               = "Yearly Interest Rate Must Be Numeric.";
        const string  errMsg4               = "Yearly Interest Rate Out-Of-Range.";
        const string  errMsg5               = "Number Of Years Must Be Numeric.";
        const string  errMsg6               = "Number Of Years Out-Of-Range.";

        static void Main(string[] args)
        {
            Clear();
            decimal monthlyInvestment   = inputMonthlyInvestment();
            decimal yearlyInterestRate  = inputYearlyInterestRate();
            int     numberYears         = inputNumberYears();
            decimal futureValue         = calculateFutureValue(monthlyInvestment,
                                                               yearlyInterestRate,
                                                               numberYears);
            printOutStatistics(monthlyInvestment, yearlyInterestRate,
                               numberYears, futureValue);
       }

        //  Input monthly investment (must be between 1000 and 1000000)
        static decimal inputMonthlyInvestment()
        {
            decimal miDec = 0.0M;
            string  miStr = "";
            bool    result;

            Write("\nEnter a monthly investment between " +
                 MINMONTHLYINVESTMENT.ToString("c2") + " and " +
                 MAXMONTHLYINVESTMENT.ToString("c2")  + ":\t");
            miStr = ReadLine();
            result = decimal.TryParse(miStr, out miDec);

            //  If non-numeric input, show message and call function again
            if (!result)
            {
                WriteLine(errMsg1 + errMsg0);
                ReadLine();
                inputMonthlyInvestment();
            }

            //  Input was numeric. Validate it is within range
            //  If oor input, show message and call function again
            if ((miDec < MINMONTHLYINVESTMENT) || (miDec > MAXMONTHLYINVESTMENT))
            {
                WriteLine(errMsg2 + errMsg0);
                ReadLine();
                inputMonthlyInvestment();
            }

            return miDec;
        }

        //  Input yearly interest rate (must be between 1 and 10)
        static decimal inputYearlyInterestRate()
        {
            decimal yirDec = 0.0M;
            string  yirStr = "";
            bool    result;

            Write("\nEnter a yearly interest rate between " +
                 MINYEARLYINTERESTRATE.ToString("n2") + " and " +
                 MAXYEARLYINTERESTRATE.ToString("n2") + ":\t\t");
            yirStr = ReadLine();
            result = decimal.TryParse(yirStr, out yirDec);

            //  If non-numeric input, show message and call function again
            if (!result)
            {
                WriteLine(errMsg3 + errMsg0);
                ReadLine();
                inputYearlyInterestRate();
            }

            //  Input was numeric. Validate it is within range
            //  If oor input, show message and call function again
            if ((yirDec < MINYEARLYINTERESTRATE) || (yirDec > MAXYEARLYINTERESTRATE))
            {
                WriteLine(errMsg4 + errMsg0);
                ReadLine();
                inputYearlyInterestRate();
            }

            return yirDec;
        }

        //  Input number of years (must be between 5 and 25)
        static int inputNumberYears()
        {
            int    noyInt   = 0; ;
            string noyStr   = "";
            bool   result;

            Write("\nEnter number of years between " +
                 MINNUMBEROFYEARS.ToString() + " and " +
                 MAXNUMBEROFYEARS.ToString() + ":\t\t\t\t");
            noyStr = ReadLine();
            result = Int32.TryParse(noyStr, out noyInt);

            //  If non-numeric input, show message and call function again
            if (!result)
            {
                WriteLine(errMsg5 + errMsg0);
                ReadLine();
                inputNumberYears();
            }

            //  Input was numeric. Validate it is within range
            //  If oor input, show message and call function again
            if ((noyInt < MINNUMBEROFYEARS) || (noyInt > MAXNUMBEROFYEARS))
            {
                WriteLine(errMsg6 + errMsg0);
                ReadLine();
                inputNumberYears();
            }

            return noyInt;
        }

        //  Calculate the future value
        static decimal calculateFutureValue(decimal mi,
                                            decimal yir,
                                            int     ny)
        {
            int months = ny * 12;
            decimal monthlyInterestRate = yir / 12 / 100;

            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + mi)
                            * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        //  Output monthly investment, yearly interest rate,
        //  number of years, and future value
        static void printOutStatistics(decimal mi, decimal yir,
                                       int ny, decimal fv)
        {
            string outputStr  = "\n\nMonthly Investment:\t\t"   + mi.ToString("c")   + "\n";
            outputStr        += "Yearly Interest Rate:\t\t"     + yir.ToString("n2") + "%\n";
            outputStr        += "Number Of Years:\t\t"          + ny.ToString()      + "\n";
            outputStr        += "Future Value:\t\t\t"           + fv.ToString("c")   + "\n";
            Write(outputStr);
            ReadLine();
        }
    }
}
