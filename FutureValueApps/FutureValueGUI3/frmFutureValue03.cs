using System;
using System.Windows.Forms;



/*
 *      This is a C# console program that will let the user
 *      create a future value, based on the following:
 *      
 *      monthly investment      -   Must be between 1000 and 1000000
 *      yearly interest rate    -   Must be between 1% (0.01) and 10% (0.1)
 *      number of years         -   Must be between 10 and 25
 */

namespace FutureValueGUI1
{
    public partial class frmFutureValue03 : Form
    {
        public frmFutureValue03()
        {
            InitializeComponent();
        }

        //  Global constants
        const decimal MINMONTHLYINVESTMENT  =    1000.00M;
        const decimal MAXMONTHLYINVESTMENT  = 1000000.00M;
        const decimal MINYEARLYINTERESTRATE =       1.00M;
        const decimal MAXYEARLYINTERESTRATE =      10.00M;
        const int     MINNUMBEROFYEARS      =       5;
        const int     MAXNUMBEROFYEARS      =      25;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment  = Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
                    int numberOfYears          = Convert.ToInt32(txtNumberOfYears.Text);

                    int months = numberOfYears * 12;
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
                    calculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
                }
            }
            catch (Exception ex)
            {
                showMessage(ex.Message, "ERROR OCCURRED");
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errMsg = "";

            errMsg += IsPresent(txtMonthlyInvestment.Text, txtMonthlyInvestment.Tag.ToString());
            errMsg += IsDecimal(txtMonthlyInvestment.Text, txtMonthlyInvestment.Tag.ToString());
            errMsg += IsWithinRange(txtMonthlyInvestment.Text, txtMonthlyInvestment.Tag.ToString(),
                                    MINMONTHLYINVESTMENT, MAXMONTHLYINVESTMENT);

            errMsg += IsPresent(txtYearlyInterestRate.Text, txtYearlyInterestRate.Tag.ToString());
            errMsg += IsDecimal(txtYearlyInterestRate.Text, txtYearlyInterestRate.Tag.ToString());
            errMsg += IsWithinRange(txtYearlyInterestRate.Text, txtYearlyInterestRate.Tag.ToString(),
                                    MINYEARLYINTERESTRATE, MAXYEARLYINTERESTRATE);

            errMsg += IsPresent(txtNumberOfYears.Text, txtNumberOfYears.Tag.ToString());
            errMsg += IsDecimal(txtNumberOfYears.Text, txtNumberOfYears.Tag.ToString());
            errMsg += IsWithinRange(txtNumberOfYears.Text, txtNumberOfYears.Tag.ToString(),
                                    MINNUMBEROFYEARS, MAXNUMBEROFYEARS);

            if (errMsg != "")
            {
                success = false;
                showMessage(errMsg, "ENTRY ERROR");
            }

            return success;
        }

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field.\n\n";
            }
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value.\n\n";
            }
            return msg;
        }

        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value.\n\n";
            }
            return msg;
        }

        public static string IsWithinRange(string value, string name, decimal min,
            decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + ".\n\n";
                }
            }
            return msg;
        }


        private void llClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clearAllFields();
        }

        private void calculateFutureValue(decimal monthlyInvestment,
                                          decimal yearlyInterestRate,
                                          int     numberOfyears)
        {
            int     months              = numberOfyears * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue         = 0m;
            for (int lcv = 0; lcv < months; lcv++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");
        }

        public void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title);
        }

        private void clearAllFields()
        {
            txtMonthlyInvestment.Text   = "";
            txtYearlyInterestRate.Text  = "";
            txtNumberOfYears.Text       = "";
            txtFutureValue.Text         = "";
            txtMonthlyInvestment.Focus();
        }
    }
}
