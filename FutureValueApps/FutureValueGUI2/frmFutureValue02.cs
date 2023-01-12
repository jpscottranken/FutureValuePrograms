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
    public partial class frmFutureValue02 : Form
    {
        public frmFutureValue02()
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
        const string  ERRMSG0               = "\nPlease try again.";
        const string  MIRTITLE              = "MONTHLY INVESTMENT ERROR!";
        const string  MIRERRMSG1            = "Monthly Investment Is Required.";
        const string  MIRERRMSG2            = "Monthly Investment Must Be Numeric.";
        const string  MIRERRMSG3            = "Monthly Investment Out-Of-Range.";
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
        }

        private bool validateMonthlyInvestment()
        {
            bool result;
            bool retVal = true;
            decimal monthlyInvestment;

            try
            {
                if (txtMonthlyInvestment.Text == "")
                {
                    throw new ArgumentException();
                }

                result = Decimal.TryParse(txtMonthlyInvestment.Text, out monthlyInvestment);
                if (!result)
                {
                    throw new FormatException();
                }

                if ((monthlyInvestment < MINMONTHLYINVESTMENT) ||
                    (monthlyInvestment > MAXMONTHLYINVESTMENT))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                showMessage(MIRERRMSG3 + ERRMSG0 + "\n" + aoore, MIRTITLE);
                txtMonthlyInvestment.Text = "";
                txtMonthlyInvestment.Focus();
                retVal = false;
            }

            catch (ArgumentException ae)
            {
                showMessage(MIRERRMSG1 + ERRMSG0 + "\n" + ae, MIRTITLE);
                txtMonthlyInvestment.Text = "";
                txtMonthlyInvestment.Focus();
                retVal = false;
            }

            catch (FormatException fe)
            {
                showMessage(MIRERRMSG2 + ERRMSG0 + "\n" + fe, MIRTITLE);
                txtMonthlyInvestment.Text = "";
                txtMonthlyInvestment.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool validateYearlyInterestRate()
        {
            bool result;
            bool retVal = true;
            decimal yearlyInterestRate;

            try
            {
                if (txtYearlyInterestRate.Text == "")
                {
                    throw new ArgumentException();
                }

                result = Decimal.TryParse(txtYearlyInterestRate.Text, out yearlyInterestRate);
                if (!result)
                {
                    throw new FormatException();
                }

                if ((yearlyInterestRate < MINYEARLYINTERESTRATE) ||
                    (yearlyInterestRate > MAXYEARLYINTERESTRATE))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                showMessage(YIRERRMSG3 + ERRMSG0 + "\n" + aoore, YIRTITLE);
                txtYearlyInterestRate.Text = "";
                txtYearlyInterestRate.Focus();
                retVal = false;
            }

            catch (ArgumentException ae)
            {
                showMessage(YIRERRMSG1 + ERRMSG0 + "\n" + ae, YIRTITLE);
                txtYearlyInterestRate.Text = "";
                txtYearlyInterestRate.Focus();
                retVal = false;
            }

            catch (FormatException fe)
            {
                showMessage(YIRERRMSG2 + ERRMSG0 + "\n" + fe, YIRTITLE);
                txtYearlyInterestRate.Text = "";
                txtYearlyInterestRate.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool validateNumberOfYears()
        {
            bool result;
            bool retVal = true;
            decimal numberOfYears;

            try
            {
                if (txtNumberOfYears.Text == "")
                {
                    throw new ArgumentException();
                }

                result = Decimal.TryParse(txtNumberOfYears.Text, out numberOfYears);
                if (!result)
                {
                    throw new FormatException();
                }

                if ((numberOfYears < MINNUMBEROFYEARS) ||
                    (numberOfYears > MAXNUMBEROFYEARS))
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                showMessage(NOYERRMSG3 + ERRMSG0 + "\n" + aoore, NOYTITLE);
                txtNumberOfYears.Text = "";
                txtNumberOfYears.Focus();
                retVal = false;
            }

            catch (ArgumentException ae)
            {
                showMessage(NOYERRMSG1 + ERRMSG0 + "\n" + ae, NOYTITLE);
                txtNumberOfYears.Text = "";
                txtNumberOfYears.Focus();
                retVal = false;
            }

            catch (FormatException fe)
            {
                showMessage(NOYERRMSG2 + ERRMSG0 + "\n" + fe, NOYTITLE);
                txtNumberOfYears.Text = "";
                txtNumberOfYears.Focus();
                retVal = false;
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
