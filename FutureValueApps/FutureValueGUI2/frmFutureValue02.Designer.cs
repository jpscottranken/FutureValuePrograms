namespace FutureValueGUI1
{
    partial class frmFutureValue02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMonthlyInvestment = new System.Windows.Forms.Label();
            this.lblYearlyInterestRate = new System.Windows.Forms.Label();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.lblFutureValue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtMonthlyInvestment = new System.Windows.Forms.TextBox();
            this.txtYearlyInterestRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.llClear = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(35, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(501, 60);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Future Value Calculator";
            // 
            // lblMonthlyInvestment
            // 
            this.lblMonthlyInvestment.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyInvestment.ForeColor = System.Drawing.Color.Black;
            this.lblMonthlyInvestment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMonthlyInvestment.Location = new System.Drawing.Point(39, 108);
            this.lblMonthlyInvestment.Name = "lblMonthlyInvestment";
            this.lblMonthlyInvestment.Size = new System.Drawing.Size(260, 31);
            this.lblMonthlyInvestment.TabIndex = 6;
            this.lblMonthlyInvestment.Text = "Monthly Investment:";
            this.lblMonthlyInvestment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYearlyInterestRate
            // 
            this.lblYearlyInterestRate.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.lblYearlyInterestRate.ForeColor = System.Drawing.Color.Black;
            this.lblYearlyInterestRate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblYearlyInterestRate.Location = new System.Drawing.Point(39, 159);
            this.lblYearlyInterestRate.Name = "lblYearlyInterestRate";
            this.lblYearlyInterestRate.Size = new System.Drawing.Size(260, 31);
            this.lblYearlyInterestRate.TabIndex = 7;
            this.lblYearlyInterestRate.Text = "Yearly Interest Rate:";
            this.lblYearlyInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfYears.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfYears.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumberOfYears.Location = new System.Drawing.Point(39, 209);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(260, 31);
            this.lblNumberOfYears.TabIndex = 8;
            this.lblNumberOfYears.Text = "Number Of Years:";
            this.lblNumberOfYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFutureValue
            // 
            this.lblFutureValue.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.lblFutureValue.ForeColor = System.Drawing.Color.Black;
            this.lblFutureValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFutureValue.Location = new System.Drawing.Point(39, 266);
            this.lblFutureValue.Name = "lblFutureValue";
            this.lblFutureValue.Size = new System.Drawing.Size(260, 31);
            this.lblFutureValue.TabIndex = 9;
            this.lblFutureValue.Text = "Future Value:";
            this.lblFutureValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(45, 337);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 42);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtMonthlyInvestment
            // 
            this.txtMonthlyInvestment.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyInvestment.Location = new System.Drawing.Point(341, 108);
            this.txtMonthlyInvestment.Name = "txtMonthlyInvestment";
            this.txtMonthlyInvestment.Size = new System.Drawing.Size(274, 38);
            this.txtMonthlyInvestment.TabIndex = 0;
            this.txtMonthlyInvestment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYearlyInterestRate
            // 
            this.txtYearlyInterestRate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearlyInterestRate.Location = new System.Drawing.Point(341, 159);
            this.txtYearlyInterestRate.Name = "txtYearlyInterestRate";
            this.txtYearlyInterestRate.Size = new System.Drawing.Size(274, 38);
            this.txtYearlyInterestRate.TabIndex = 1;
            this.txtYearlyInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfYears.Location = new System.Drawing.Point(341, 209);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(274, 38);
            this.txtNumberOfYears.TabIndex = 2;
            this.txtNumberOfYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFutureValue.Location = new System.Drawing.Point(341, 266);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(274, 38);
            this.txtFutureValue.TabIndex = 5;
            this.txtFutureValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // llClear
            // 
            this.llClear.AutoSize = true;
            this.llClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llClear.Location = new System.Drawing.Point(202, 343);
            this.llClear.Name = "llClear";
            this.llClear.Size = new System.Drawing.Size(69, 31);
            this.llClear.TabIndex = 4;
            this.llClear.TabStop = true;
            this.llClear.Text = "Clear";
            this.llClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClear_LinkClicked);
            // 
            // frmFutureValue02
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.llClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llClear);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.txtYearlyInterestRate);
            this.Controls.Add(this.txtMonthlyInvestment);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFutureValue);
            this.Controls.Add(this.lblNumberOfYears);
            this.Controls.Add(this.lblYearlyInterestRate);
            this.Controls.Add(this.lblMonthlyInvestment);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmFutureValue02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value Application - GUI #2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMonthlyInvestment;
        private System.Windows.Forms.Label lblYearlyInterestRate;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.Label lblFutureValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtMonthlyInvestment;
        private System.Windows.Forms.TextBox txtYearlyInterestRate;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.LinkLabel llClear;
    }
}

