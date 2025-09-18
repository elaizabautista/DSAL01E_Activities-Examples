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

        // Converts textbox value to double, returns 0 if invalid
        private double ParseValue(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
                return 0.0;
            double val;
            return double.TryParse(txt.Text.Replace(",", ""), out val) ? val : 0.0;
        }

        // Calculates incomes, gross income, and contributions
        private void grossincome_btn_Click(object sender, EventArgs e)
        {

            // Calculate basic, honorarium, and other incomes
            basicIncome = ParseValue(BIratehour_Txtbox) * ParseValue(BINoofHours_Txtbox);
            BIincomecutoff_Txtbox.Text = basicIncome.ToString("N2");

            honorariumIncome = ParseValue(HIratehour_Txtbox) * ParseValue(HINoofHours_Txtbox);
            HIincomecutoff_Txtbox.Text = honorariumIncome.ToString("N2");

            otherIncome = ParseValue(OIratehour_Txtbox) * ParseValue(OINoofHours_Txtbox);
            OIincomecutoff_Txtbox.Text = otherIncome.ToString("N2");

            grossIncome = basicIncome + honorariumIncome + otherIncome;
            grossincome_Txtbox.Text = grossIncome.ToString("N2");

            // -------------------------------
            //SSS Contribution
            double sssContribution = 0;
            if (grossIncome <= 3250)
                sssContribution = 135.00;
            else if (grossIncome <= 3750)
                sssContribution = 157.50;
            else if (grossIncome <= 4250)
                sssContribution = 180.00;
            else if (grossIncome <= 4750)
                sssContribution = 202.50;
            else if (grossIncome <= 5250)
                sssContribution = 225.00;
            else if (grossIncome <= 5750)
                sssContribution = 247.50;
            else if (grossIncome <= 6250)
                sssContribution = 270.00;
            else if (grossIncome <= 6750)
                sssContribution = 292.50;
            else if (grossIncome <= 7250)
                sssContribution = 315.00;
            else
                sssContribution = 337.50;

            SSScontribution_Txtbox.Text = sssContribution.ToString("N2");

            // -------------------------------
            // PhilHealth Contribution
            double philhealthContribution = 0;
            if (grossIncome <= 10000)
                philhealthContribution = 350.00;
            else if (grossIncome <= 59999.99)
                philhealthContribution = grossIncome * 0.035;
            else
                philhealthContribution = 2100.00;

            philhealthcontribution_Txtbox.Text = philhealthContribution.ToString("N2");

            //Pag-IBIG Contribution
            double pagibigContribution = 200.00;
            pagibigcontribution_Txtbox.Text = pagibigContribution.ToString("N2");
           
            // Income Tax (TRAIN Law)
            double annualGross = grossIncome * 12;
            double annualTax = 0;

            if (annualGross <= 250000)
                annualTax = 0;
            else if (annualGross <= 400000)
                annualTax = (annualGross - 250000) * 0.20;
            else if (annualGross <= 800000)
                annualTax = 30000 + (annualGross - 400000) * 0.25;
            else if (annualGross <= 2000000)
                annualTax = 130000 + (annualGross - 800000) * 0.30;
            else if (annualGross <= 8000000)
                annualTax = 490000 + (annualGross - 2000000) * 0.32;
            else
                annualTax = 2410000 + (annualGross - 8000000) * 0.35;

            double monthlyTax = annualTax / 12;
            incometaxcontribution_Txtbox.Text = monthlyTax.ToString("N2");
        }

        private double GetPhilHealthContribution(double grossIncome)
        {
            // 2025: 4% of gross, min 400, max 1600
            double contribution = grossIncome * 0.04;
            if (contribution < 400) return 400;
            if (contribution > 1600) return 1600;
            return contribution;
        }

        // Calculates total deductions and net income
        private void netincome_btn_Click(object sender, EventArgs e)
        {

            double sss = ParseValue(SSScontribution_Txtbox);
            double philhealth = ParseValue(philhealthcontribution_Txtbox);
            double incometax = ParseValue(incometaxcontribution_Txtbox);
            double pagibigContribution = ParseValue(pagibigcontribution_Txtbox);

            double sssLoan = ParseValue(SSSloan_Txtbox);
            double pagibigLoan = ParseValue(pagibigloan_Txtbox);
            double facultySavingsDeposit = ParseValue(facultysavingsdeposit_Txtbox);
            double facultySavingsLoan = ParseValue(facultysavingsloan_Txtbox);
            double salaryLoan = ParseValue(salaryloan_Txtbox);
            double otherLoans = ParseValue(otherloans_Txtbox);

            totalDeductions = sss + philhealth + incometax + pagibigContribution +
                              sssLoan + pagibigLoan + facultySavingsDeposit +
                              facultySavingsLoan + salaryLoan + otherLoans;

            totaldeduction_Txtbox.Text = totalDeductions.ToString("N2");

            netIncome = grossIncome - totalDeductions;
            netincome_Txtbox.Text = netIncome.ToString("N2");
        }


        // Loads an image into pictureBox1
        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            // Clears all textboxes on the form
            BIratehour_Txtbox.Clear();
            BINoofHours_Txtbox.Clear();
            BIincomecutoff_Txtbox.Clear();

            HIratehour_Txtbox.Clear();
            HINoofHours_Txtbox.Clear();
            HIincomecutoff_Txtbox.Clear();

            OIratehour_Txtbox.Clear();
            OINoofHours_Txtbox.Clear();
            OIincomecutoff_Txtbox.Clear();

            grossincome_Txtbox.Clear();

            SSScontribution_Txtbox.Clear();
            philhealthcontribution_Txtbox.Clear();
            pagibigcontribution_Txtbox.Clear();
            incometaxcontribution_Txtbox.Clear();

            SSSloan_Txtbox.Clear();
            pagibigloan_Txtbox.Clear();
            facultysavingsdeposit_Txtbox.Clear();
            facultysavingsloan_Txtbox.Clear();
            salaryloan_Txtbox.Clear();
            otherloans_Txtbox.Clear();

            totaldeduction_Txtbox.Clear();
            netincome_Txtbox.Clear();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
        // Combine first name, middle name, and surname 
        string fullName = firstname_Txtbox.Text + " " + middlename_Txtbox.Text + " " + surname_Txtbox.Text;
        
        //for the paydate
        string paydate = paydate_Txtbox.Text;
            
        // Create and show the PayslipReport form with all necessary data
        PayslipReport payslip = new PayslipReport(
        
        employeeno_Txtbox.Text,
        fullName, //combined name
        paydate,   // cutoff
        paydate,   // payperiod (same value as cutoff)
        
        "College of Engineering, Computer Studies and Architecture", 
        
        basicIncome,
        honorariumIncome,
        otherIncome,
        grossIncome,
        totalDeductions,
        netIncome,
        SSScontribution_Txtbox.Text,
        philhealthcontribution_Txtbox.Text,
        pagibigcontribution_Txtbox.Text,
        incometaxcontribution_Txtbox.Text
    );
            payslip.ShowDialog();
        }
    }
}