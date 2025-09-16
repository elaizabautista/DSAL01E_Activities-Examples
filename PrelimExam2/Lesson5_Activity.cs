using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrelimExam2
{
    public partial class Lesson5_Activity : Form
    {
        private double basicIncome;
        private double honorariumIncome;
        private double otherIncome;
        private double grossIncome;
        private double totalDeductions;
        private double netIncome;
        public Lesson5_Activity()
        {
            InitializeComponent();
        }
            private double GetValueFromTextBox(TextBox textBox)
        {
            double value;
            string cleanedText = textBox.Text.Replace(",", "");
            if (double.TryParse(cleanedText, out value))
            {
                return value;
            }
            return 0.0;
        }

        private void grossincome_btn_Click(object sender, EventArgs e)
        {

            basicIncome = GetValueFromTextBox(BIratehour_Txtbox) * GetValueFromTextBox(BINoofHours_Txtbox);
            BIincomecutoff_Txtbox.Text = basicIncome.ToString("N2");

            honorariumIncome = GetValueFromTextBox(HIratehour_Txtbox) * GetValueFromTextBox(HINoofHours_Txtbox);
            HIincomecutoff_Txtbox.Text = honorariumIncome.ToString("N2");

            otherIncome = GetValueFromTextBox(OIratehour_Txtbox) * GetValueFromTextBox(OINoofHours_Txtbox);
            OIincomecutoff_Txtbox.Text = otherIncome.ToString("N2");

            grossIncome = basicIncome + honorariumIncome + otherIncome;
            grossincome_Txtbox.Text = grossIncome.ToString("N2");

            // Regular Deductions
            SSScontribution_Txtbox.Text = (grossIncome * 0.0363).ToString("N2");
            philhealthcontribution_Txtbox.Text = (grossIncome * 0.035).ToString("N2");
            incometaxcontribution_Txtbox.Text = (grossIncome * 0.10).ToString("N2");
            pagibigcontribution_Txtbox.Text = 200.00.ToString("N2");

            // Other Deductions (automatically calculated based on Gross Income)
            SSSloan_Txtbox.Text = (grossIncome * 0.02).ToString("N2");
            pagibigloan_Txtbox.Text = (grossIncome * 0.01).ToString("N2");
            facultysavingsdeposit_Txtbox.Text = (grossIncome * 0.015).ToString("N2");
            facultysavingsloan_Txtbox.Text = (grossIncome * 0.01).ToString("N2");
            salaryloan_Txtbox.Text = (grossIncome * 0.025).ToString("N2");
            otherloans_Txtbox.Text = (grossIncome * 0.005).ToString("N2");
        }
       
        private void netincome_btn_Click(object sender, EventArgs e)
        {

            double sss = GetValueFromTextBox(SSScontribution_Txtbox);
            double philhealth = GetValueFromTextBox(philhealthcontribution_Txtbox);
            double incometax = GetValueFromTextBox(incometaxcontribution_Txtbox);
            double pagibigContribution = GetValueFromTextBox(pagibigcontribution_Txtbox);

            double sssLoan = GetValueFromTextBox(SSSloan_Txtbox);
            double pagibigLoan = GetValueFromTextBox(pagibigloan_Txtbox);
            double facultySavingsDeposit = GetValueFromTextBox(facultysavingsdeposit_Txtbox);
            double facultySavingsLoan = GetValueFromTextBox(facultysavingsloan_Txtbox);
            double salaryLoan = GetValueFromTextBox(salaryloan_Txtbox);
            double otherLoans = GetValueFromTextBox(otherloans_Txtbox);

            totalDeductions = sss + philhealth + incometax + pagibigContribution +
                              sssLoan + pagibigLoan + facultySavingsDeposit + facultySavingsLoan +
                              salaryLoan + otherLoans;

            totaldeduction_Txtbox.Text = totalDeductions.ToString("N2");

            netIncome = grossIncome - totalDeductions;
            netincome_Txtbox.Text = netIncome.ToString("N2");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
            }

        }
    }
}
