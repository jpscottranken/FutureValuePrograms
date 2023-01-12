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
    public partial class frmFutureValue01 : Form
    {
        public frmFutureValue01()
        {
            InitializeComponent();
        }

        //  Global constants
        const decimal MINMONTHLYINVESTMENT  =    1000.00M;
        const decimal MAXMONTHLYINVESTMENT  = 1000000.00M;
        const decimal MINYEARLYINTERESTRATE =       1.00M;
        const decimal MAXYEARLYINTERESTRATE =      10.00M;
        const int     MINNUMBEROFYEARS      =      10;
        const int     MAXNUMBEROFYEARS      =      25;
        const string  ERRMSG0               = "\nPlease try again.";
        const string  MITITLE               = "MONTHLY INVESTMENT ERROR!";
        const string  MIERRMSG1             = "Monthly Investment Is Required.";
        const string  MIERRMSG2             = "Monthly Investment Must Be Numeric.";
        const string  MIERRMSG3             = "Monthly Investment Out-Of-Range.";
        const string  YIRTITLE              = "YEARLY INTEREST RATE ERROR!";
        const string  YIRERRMSG1            = "Yearly Interest Rate Is Required.";
        const string  YIRERRMSG2            = "Yearly Interest Rate Must Be Numeric.";
        const string  YIRERRMSG3            = "Yearly Interest Rate Out-Of-Range.";
        const string  NOYTITLE              = "NUMBER YEARS REQUIRED ERROR!";
        const string  NOYERRMSG1            = "Number Of Years Is Required.";
        const string  NOYERRMSG2            = "Number Of Years Must Be Numeric.";
        const string  NOYERRMSG3            = "Number Of Years Out-Of-Range.";

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = validateMonthlyInvestment();

            if (keepGoing)
            {
                keepGoing = validateYearlyInterestRate();
            }
            else
            {
                return;
            }
            
            if (keepGoing)
            {
                keepGoing = validateNumberOfYears();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                calculateFutureValue();
            }
            else
            {
                return;
            }
        }

        private bool validateMonthlyInvestment()
        {
            bool result;
            bool retVal = true;
            decimal monthlyInvestment;

            if (txtMonthlyInvestment.Text.Trim() == "")
            {
                showMessage(MIERRMSG1 + ERRMSG0, MITITLE);
                txtMonthlyInvestment.Focus();
                retVal = false;
            }
            else
            {
                result = Decimal.TryParse(txtMonthlyInvestment.Text, out monthlyInvestment);
                if (!result)
                {
                    showMessage(MIERRMSG2 + ERRMSG0, MITITLE);
                    txtMonthlyInvestment.Text = "";
                    txtMonthlyInvestment.Focus();
                    retVal = false;
                }
                else if ((monthlyInvestment < MINMONTHLYINVESTMENT) ||
                         (monthlyInvestment > MAXMONTHLYINVESTMENT))
                {
                    showMessage(MIERRMSG3 + ERRMSG0, MITITLE);
                    txtMonthlyInvestment.Text = "";
                    txtMonthlyInvestment.Focus();
                    retVal = false;
                }
            }

            return retVal;
        }

        private bool validateYearlyInterestRate()
        {
            bool result;
            bool retVal = true;
            decimal yearlyInterestRate;

            if (txtYearlyInterestRate.Text.Trim() == "")
            {
                showMessage(YIRERRMSG1 + ERRMSG0, YIRTITLE);
                txtYearlyInterestRate.Focus();
                retVal = false;
            }
            else
            {
                result = Decimal.TryParse(txtYearlyInterestRate.Text, out yearlyInterestRate);
                if (!result)
                {
                    showMessage(YIRERRMSG2 + ERRMSG0, YIRTITLE);
                    txtYearlyInterestRate.Text = "";
                    txtYearlyInterestRate.Focus();
                    retVal = false;
                }
                else if ((yearlyInterestRate < MINYEARLYINTERESTRATE) ||
                         (yearlyInterestRate > MAXYEARLYINTERESTRATE))
                {
                    showMessage(YIRERRMSG3 + ERRMSG0, YIRTITLE);
                    txtYearlyInterestRate.Text = "";
                    txtYearlyInterestRate.Focus();
                    retVal = false;
                }
            }

            return retVal;
        }

        private bool validateNumberOfYears()
        {
            bool result;
            bool retVal = true;
            decimal numberOfYears;

            if (txtNumberOfYears.Text.Trim() == "")
            {
                showMessage(NOYERRMSG1 + ERRMSG0, NOYTITLE);
                txtNumberOfYears.Focus();
                retVal = false;
            }
            else
            {
                result = Decimal.TryParse(txtNumberOfYears.Text, out numberOfYears);
                if (!result)
                {
                    showMessage(NOYERRMSG2 + ERRMSG0, NOYTITLE);
                    txtNumberOfYears.Text = "";
                    txtNumberOfYears.Focus();
                    retVal = false;
                }
                else if ((numberOfYears < MINNUMBEROFYEARS) ||
                         (numberOfYears > MAXNUMBEROFYEARS))
                {
                    showMessage(NOYERRMSG3 + ERRMSG0, NOYTITLE);
                    txtNumberOfYears.Text = "";
                    txtNumberOfYears.Focus();
                    retVal = false;
                }
            }

            return retVal;
        }

        private void llClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clearAllFields();
        }

        private void calculateFutureValue()
        {
            decimal monthlyInvestment   = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate  = Convert.ToDecimal(txtYearlyInterestRate.Text);
            int     numberOfyears       = Convert.ToInt32(txtNumberOfYears.Text);

            int     months              = numberOfyears * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue         = 0m;
            for (int lcv = 0; lcv < months; lcv++)
            {
                futureValue = (futureValue + monthlyInvestment)
                            * (1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
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
