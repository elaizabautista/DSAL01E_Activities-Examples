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

            // Individual earnings
            lblBasicPay.Text = basicIncome.ToString("N2");
            lblHonorarium.Text = honorariumIncome.ToString("N2");
            lblOvertime.Text = otherIncome.ToString("N2");
            lblHonorariumAdjustment.Text = "0.00";
            lblTardy.Text = "0.00";
            lblSubstitution.Text = "0.00";

            // Total earnings / gross income
            double totalEarnings = basicIncome + 0 + 0 + 0 + otherIncome;
            lblearningsTotal.Text = totalEarnings.ToString("N2");
            lblGrossEarnings.Text = totalEarnings.ToString("N2");

            // SSS contribution (from Form1)
            double sssVal;
            double.TryParse(sssContribution.Replace(",", ""), out sssVal);
            lblSSS.Text = sssVal.ToString("N2");

            // SSS WISP fixed at 750
            double sssWISPVal = 750.00;
            lblSSSWISP.Text = sssWISPVal.ToString("N2");

            // Fixed HDMF (Pag-IBIG)
            double HDMFVal = 200.00;
            lblHDMF.Text = HDMFVal.ToString("N2");

            // PhilHealth
            double philhealthVal;
            double.TryParse(philhealthContribution.Replace(",", ""), out philhealthVal);
            lblPhilhealth.Text = philhealthVal.ToString("N2");

            // Withholding Tax
            double withholdingTaxVal;
            double.TryParse(incomeTaxContribution.Replace(",", ""), out withholdingTaxVal);
            lblWithholdingTax.Text = withholdingTaxVal.ToString("N2");

            // lblDeductionsTotal = sum of all contributions/deductions
            double sumDeductions = sssVal + sssWISPVal + HDMFVal + philhealthVal + withholdingTaxVal;
            lblDeductionsTotal.Text = sumDeductions.ToString("N2");

            // lblTotalDeductions can remain the value from Form1
            lblTotalDeductions.Text = totalDeductions.ToString("N2");

            // Net pay
            double netPay = totalEarnings - sumDeductions;
            lblNetPay.Text = netPay.ToString("N2");

            // Overtime total
            lblOvertimeTotal.Text = otherIncome.ToString("N2");

        }
    }
}