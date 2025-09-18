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
    public partial class PayslipReport : Form
    {
        public PayslipReport(
            string employeeCode,
            string employeeName,
            string cutoff,
            string payPeriod,
            string department,
            double basicIncome,
            double honorariumIncome,
            double otherIncome,
            double grossIncome,
            double totalDeductions,
            double netIncome,
            string sssContribution,
            string philhealthContribution,
            string pagibigContribution,
            string incomeTaxContribution
   )
        {
            InitializeComponent();

            // Company and employee info
            lblCompany.Text = "Lyceum of the Philippines University Cavite";
            lblEmployeeCode.Text = employeeCode;
            lblEmployeeName.Text = employeeName;
            lblCutoff.Text = cutoff;
            lblPayPeriod.Text = payPeriod;
            lblDepartment.Text = department;

            // Earnings
            lblBasicPay.Text = basicIncome.ToString("N2");
            lblHonorarium.Text = honorariumIncome.ToString("N2");
            lblOvertime.Text = otherIncome.ToString("N2");

            // Fixed adjustments
            lblHonorariumAdjustment.Text = "0.00";
            lblSubstitution.Text = "0.00";
            lblTardy.Text = "0.00";

            // Total earnings = Basic + Honorarium + Overtime
            double totalEarnings = basicIncome + honorariumIncome + otherIncome;
            lblearningsTotal.Text = totalEarnings.ToString("N2");
            lblGrossEarnings.Text = totalEarnings.ToString("N2");

            // Parse individual deductions (from main form)
            double sssVal = double.TryParse(sssContribution, out double tempSSS) ? tempSSS : 0.0;
            double philhealthVal = double.TryParse(philhealthContribution, out double tempPH) ? tempPH : 0.0;
            double pagibigVal = double.TryParse(pagibigContribution, out double tempPI) ? tempPI : 0.0;
            double withholdingTaxVal = double.TryParse(incomeTaxContribution, out double tempTax) ? tempTax : 0.0;

            // Fixed deductions same as main form
            double sssWISPVal = 750.00;
            double hdmfVal = 200.00;

            // Display individual deductions
            lblSSS.Text = sssVal.ToString("N2");
            lblSSSWISP.Text = sssWISPVal.ToString("N2");
            lblHDMF.Text = hdmfVal.ToString("N2");
            lblPhilhealth.Text = philhealthVal.ToString("N2");
            lblWithholdingTax.Text = withholdingTaxVal.ToString("N2");

            // Total deductions = sum of all deductions as in main form
            double calculatedTotalDeductions = sssVal + philhealthVal + pagibigVal + withholdingTaxVal + sssWISPVal + hdmfVal;
            lblTotalDeductions.Text = calculatedTotalDeductions.ToString("N2");
            lblDeductionsTotal.Text = calculatedTotalDeductions.ToString("N2");

            // Net pay = total earnings - total deductions
            double netPay = totalEarnings - calculatedTotalDeductions;
            lblNetPay.Text = netPay.ToString("N2");

            // Overtime total
            lblOvertimeTotal.Text = otherIncome.ToString("N2");
        }

        private void label38_Click(object sender, EventArgs e)
        {
            //
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void lblDeductionsTotal_Click(object sender, EventArgs e)
        {
            //
        }
    }
}