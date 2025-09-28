using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;   // Needed for Image
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Application_Bautista
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Activity2 : Form
    {
        public Activity2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            // disable textboxes
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;

            // insert pictures into PictureBoxes
            pictureBox16.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Images\\a16.jpg");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Images\\a17.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Images\\a18.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Images\\a19.jpg");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Images\\a20.jpg");

            // insert names into Labels
            name1lbl.Text = "Midnight Brew";
            name2lbl.Text = "Velvet Sunrise";
            name3lbl.Text = "Creamy Chill Shake";
            name4lbl.Text = "Heartstrings Latte";
            name5lbl.Text = "Chocobliss Cup";
            name10lbl.Text = "Parisian Choco Twist";
            name9lbl.Text = "Choco Symphony";
            name8lbl.Text = "Strawberry Serenade";
            name7lbl.Text = "Golden Harvest Cake";
            name6lbl.Text = "Berry Dream Slice";
        }
        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

