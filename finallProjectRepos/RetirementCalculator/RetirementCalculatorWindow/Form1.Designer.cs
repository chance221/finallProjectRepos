namespace RetirementCalculatorWindow
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_Current_Age = new System.Windows.Forms.Label();
            this.label_Retirement_Age = new System.Windows.Forms.Label();
            this.saving_percentage = new System.Windows.Forms.Label();
            this.Income = new System.Windows.Forms.Label();
            this.annualIncome = new System.Windows.Forms.MaskedTextBox();
            this.retirementAge = new System.Windows.Forms.MaskedTextBox();
            this.calculate_retirement_savings = new System.Windows.Forms.Button();
            this.AmountSaved = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearsToLive = new System.Windows.Forms.MaskedTextBox();
            this.currentAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.MaximumSize = new System.Drawing.Size(300, 30);
            this.label1.MinimumSize = new System.Drawing.Size(300, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retirement Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_Current_Age
            // 
            this.label_Current_Age.AutoSize = true;
            this.label_Current_Age.Location = new System.Drawing.Point(67, 112);
            this.label_Current_Age.Name = "label_Current_Age";
            this.label_Current_Age.Size = new System.Drawing.Size(63, 13);
            this.label_Current_Age.TabIndex = 2;
            this.label_Current_Age.Text = "Current Age";
            // 
            // label_Retirement_Age
            // 
            this.label_Retirement_Age.AutoSize = true;
            this.label_Retirement_Age.Location = new System.Drawing.Point(67, 154);
            this.label_Retirement_Age.Name = "label_Retirement_Age";
            this.label_Retirement_Age.Size = new System.Drawing.Size(80, 13);
            this.label_Retirement_Age.TabIndex = 4;
            this.label_Retirement_Age.Text = "Retirement Age";
            // 
            // saving_percentage
            // 
            this.saving_percentage.AutoSize = true;
            this.saving_percentage.Location = new System.Drawing.Point(318, 147);
            this.saving_percentage.Name = "saving_percentage";
            this.saving_percentage.Size = new System.Drawing.Size(198, 13);
            this.saving_percentage.TabIndex = 6;
            this.saving_percentage.Text = "Years You Plan To Live After Retirement";
            // 
            // Income
            // 
            this.Income.AutoSize = true;
            this.Income.Location = new System.Drawing.Point(401, 116);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(115, 13);
            this.Income.TabIndex = 7;
            this.Income.Text = "Current Annual Income";
            // 
            // annualIncome
            // 
            this.annualIncome.Location = new System.Drawing.Point(555, 109);
            this.annualIncome.Name = "annualIncome";
            this.annualIncome.Size = new System.Drawing.Size(100, 20);
            this.annualIncome.TabIndex = 8;
            this.annualIncome.Text = "0.00";
            // 
            // retirementAge
            // 
            this.retirementAge.Location = new System.Drawing.Point(174, 147);
            this.retirementAge.Name = "retirementAge";
            this.retirementAge.Size = new System.Drawing.Size(43, 20);
            this.retirementAge.TabIndex = 10;
            this.retirementAge.Text = "0.00";
            this.retirementAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.retirementAge_KeyPress);
            // 
            // calculate_retirement_savings
            // 
            this.calculate_retirement_savings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculate_retirement_savings.Location = new System.Drawing.Point(252, 208);
            this.calculate_retirement_savings.Name = "calculate_retirement_savings";
            this.calculate_retirement_savings.Size = new System.Drawing.Size(169, 23);
            this.calculate_retirement_savings.TabIndex = 13;
            this.calculate_retirement_savings.Text = "Calculate Retirement Savings";
            this.calculate_retirement_savings.UseVisualStyleBackColor = true;
            this.calculate_retirement_savings.Click += new System.EventHandler(this.calculate_retirement_savings_Click);
            // 
            // AmountSaved
            // 
            this.AmountSaved.AccessibleName = "AmountSaved";
            this.AmountSaved.Location = new System.Drawing.Point(404, 265);
            this.AmountSaved.Name = "AmountSaved";
            this.AmountSaved.ReadOnly = true;
            this.AmountSaved.Size = new System.Drawing.Size(169, 20);
            this.AmountSaved.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total Retirement Savings";
            // 
            // yearsToLive
            // 
            this.yearsToLive.Location = new System.Drawing.Point(555, 147);
            this.yearsToLive.Name = "yearsToLive";
            this.yearsToLive.Size = new System.Drawing.Size(43, 20);
            this.yearsToLive.TabIndex = 17;
            this.yearsToLive.Text = "0.00";
            this.yearsToLive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearsToLive_KeyPress);
            // 
            // currentAge
            // 
            this.currentAge.AccessibleDescription = "currentAge";
            this.currentAge.AccessibleName = "currentAge";
            this.currentAge.Location = new System.Drawing.Point(174, 105);
            this.currentAge.Name = "currentAge";
            this.currentAge.Size = new System.Drawing.Size(43, 20);
            this.currentAge.TabIndex = 18;
            this.currentAge.Text = "0.00";
            this.currentAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentAge_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 328);
            this.Controls.Add(this.currentAge);
            this.Controls.Add(this.yearsToLive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AmountSaved);
            this.Controls.Add(this.calculate_retirement_savings);
            this.Controls.Add(this.retirementAge);
            this.Controls.Add(this.annualIncome);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.saving_percentage);
            this.Controls.Add(this.label_Retirement_Age);
            this.Controls.Add(this.label_Current_Age);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Retirement Calculator";
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Current_Age;
        private System.Windows.Forms.Label label_Retirement_Age;
        private System.Windows.Forms.TrackBar Savings_Percentage;
        private System.Windows.Forms.Label saving_percentage;
        private System.Windows.Forms.Label Income;
        private System.Windows.Forms.MaskedTextBox annualIncome;
        private System.Windows.Forms.MaskedTextBox retirement_Age;
        private System.Windows.Forms.Button calculate_retirement_savings;
        private System.Windows.Forms.MaskedTextBox current_Age;
        private System.Windows.Forms.TextBox AmountSaved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox retirementAge;
        private System.Windows.Forms.MaskedTextBox yearsToLive;
        private System.Windows.Forms.TextBox currentAge;
    }
}

