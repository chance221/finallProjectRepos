using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetirementCalculatorWindow
{
    //(((.80 * current salary) * (1.03^yearsOfSavings)) - (AvgSocialSecurity)) * yearsYouPlanToLive = Amt needed to retire
    public partial class Form1 : Form
    {
        double yearsOfSavings;
        double currentAge1;
        double retirementAge1;
        double currentSalary;
        double retirementYears;
        double retirementSavings;

        public Form1()
        
        {
            InitializeComponent();
        }

       

        private void calculate_retirement_savings_Click(object sender, EventArgs e)
        {
            currentAge1 = Convert.ToDouble(currentAge.Text);
            retirementAge1 = Convert.ToDouble(retirementAge.Text);
            yearsOfSavings = (retirementAge1 - currentAge1);
            currentSalary = .8 * Convert.ToDouble(annualIncome.Text);
            retirementYears = Convert.ToDouble(yearsToLive.Text);
            retirementSavings = ((currentSalary * (Math.Pow(1.03, yearsOfSavings)) - 18786) * retirementYears);
            AmountSaved.Text = retirementSavings.ToString();

        }

      
        private void currentAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? currentAge.Text.Contains(".") == true: true)) 
            e.Handled = true; 
        }

        private void retirementAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? retirementAge.Text.Contains(".") == true : true))
                e.Handled = true;
        }

        private void annualIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? annualIncome.Text.Contains(".") == true : true))
                e.Handled = true;
        }

        private void yearsToLive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? yearsToLive.Text.Contains(".") == true : true))
                e.Handled = true;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
