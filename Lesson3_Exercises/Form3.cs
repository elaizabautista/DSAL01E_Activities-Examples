using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3_Exercises
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bachelor of Science in Computer Science");
            comboBox1.Items.Add("Bachelor of Science in Aeronautical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Civil Engineering");
            comboBox1.Items.Add("Bachelor of Science in Computer Engineering");
            comboBox1.Items.Add("Bachelor of Science in Electrical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Electronics Engineering");
            comboBox1.Items.Add("Bachelor of Science in Mechanical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Industrial Engineering");

            //Disabled textboxes 
            totaltuition1.Enabled = false;
            totalmis1.Enabled = false;
            creditunits1.Enabled = false;
            total1.Enabled = false;
            tuitionandfee1.Enabled = false;
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
            // get lecture and lab units
            int lectureUnits = Convert.ToInt32(unitlecture1.Text);
            int labUnits = Convert.ToInt32(unitlaboratory1.Text);

            // add lecture and lab = credit units
            int creditUnits = lectureUnits + labUnits;
            creditunits1.Text = creditUnits.ToString();

            // tuition per unit is 1700
            double tuitionPerUnit = 1700;

            // total tuition = credit units * 1700
            double totalTuition = creditUnits * tuitionPerUnit;
            totaltuition1.Text = totalTuition.ToString("N2");

            // misc fee = booklet + cisco + lab
            double booklet = Convert.ToDouble(booklet1.Text);
            double cisco = Convert.ToDouble(cisco1.Text);
            double labFee = Convert.ToDouble(labfee1.Text);

            double totalMisc = booklet + cisco + labFee;
            totalmis1.Text = totalMisc.ToString("N2");

            // total units
            total1.Text = creditUnits.ToString();

            // tuition + misc = total
            double totalTuitionAndFees = totalTuition + totalMisc;
            tuitionandfee1.Text = totalTuitionAndFees.ToString("N2");

        }
    }
}
