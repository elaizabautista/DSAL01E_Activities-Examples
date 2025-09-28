using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAL01E_Lesson2_Activity_Bautista
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //disable some of the textboxes
            creditunits1.Enabled = false;
            total1.Enabled = false;
            totaltuition1.Enabled = false;
            totalmis1.Enabled = false;
            tuitionandfee1.Enabled = false;

            comboBox1.Items.Add("Bachelor of Science in Computer Science");
            comboBox1.Items.Add("Bachelor of Science in Aeronautical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Civil Engineering");
            comboBox1.Items.Add("Bachelor of Science in Computer Engineering");
            comboBox1.Items.Add("Bachelor of Science in Electrical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Electronics Engineering");
            comboBox1.Items.Add("Bachelor of Science in Mechanical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Industrial Engineering");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            studentname1.Text = "";
            studentnumber1.Text = "";
            yearlevel1.Text = "";
            creditunits1.Text = "";
            scholar1.Text = "";
            coursenumber1.Text = "";
            coursecode1.Text = "";
            coursedesc12.Text = "";
            unitlecture1.Text = "";
            unitlaboratory1.Text = "";
            time1.Text = "";
            day1.Text = "";
            total1.Text = "";
            labfee1.Text = "";
            totaltuition1.Text = "";
            totalmis1.Text = "";
            cisco1.Text = "";
            booklet1.Text = "";
            tuitionandfee1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coursenumberlistbox.Items.Add(coursenumber1.Text);
            coursecodelistbox.Items.Add(coursecode1.Text);
            coursedesclistbox.Items.Add(coursedesc12.Text);
            unitleclistbox.Items.Add(unitlecture1.Text);
            unitlablistbox.Items.Add(unitlaboratory1.Text);
            creditunitlistbox.Items.Add(creditunits1.Text);
            timelistbox.Items.Add(time1.Text);
            daylistbox.Items.Add(day1.Text);

            totallistbox.Items.Add(totaltuition1.Text);
            totalmislistbox.Items.Add(totalmis1.Text);
            comlablistbox.Items.Add(labfee1.Text);
            ciscolistbox.Items.Add(cisco1.Text);
            bookletlistbox.Items.Add(booklet1.Text);
            totalnumunitslistbox.Items.Add(total1.Text);
            totalfeeslistbox.Items.Add(tuitionandfee1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Calculate Credit Units for this entry
            double creditUnits = Convert.ToDouble(unitlecture1.Text) + Convert.ToDouble(unitlaboratory1.Text);
            creditunits1.Text = creditUnits.ToString();
            // Add the current entry's credit units to the running total
            double previousTotal = 0;

            // Check if there’s already a total
            if (total1.Text != "")
            {
                previousTotal = Convert.ToDouble(total1.Text);
            }

            // Add the new credit units
            double totalUnits = previousTotal + creditUnits;

            // Show the updated total
            total1.Text = totalUnits.ToString();

            // Calculate Total Tuition Fee //const is a value that cannot be changed
            const double TUITION_FEE_PER_UNIT = 1700.00;
            double totalTuitionFee = totalUnits * TUITION_FEE_PER_UNIT;
            totaltuition1.Text = totalTuitionFee.ToString("n");

            //this codes displays the calculated values in the textboxes
            // Get miscellaneous fee values
            double labFee = Convert.ToDouble(labfee1.Text);
            double ciscoFee = Convert.ToDouble(cisco1.Text);
            double bookletFee = Convert.ToDouble(booklet1.Text);

            // Calculate Total Miscellaneous Fee
            double totalMiscFee = labFee + ciscoFee + bookletFee;
            totalmis1.Text = totalMiscFee.ToString("n");

            // Calculate Total Tuition and Fees
            double totalTuitionAndFees = totalTuitionFee + totalMiscFee;
            tuitionandfee1.Text = totalTuitionAndFees.ToString("n");

        }
    }
}
