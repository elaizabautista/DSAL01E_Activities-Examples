using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Application_Bautista
{
    public partial class Activity3 : Form
    {
        public Activity3()
        {
            InitializeComponent();
            foodARdbtn.CheckedChanged += foodARdbtn_CheckedChanged;
            foodBRdtn.CheckedChanged += foodBRdtn_CheckedChanged;
        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            // default background color
            this.BackColor = Color.LightPink;

            // no bundle selected at first
            foodARdbtn.Checked = false;
            foodBRdtn.Checked = false;

            // default neutral image
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\acer\\source\\repos\\elaizabautista\\POS_Application-Bautista\\Images\\b13.jpg");

            // uncheck all items
            A_CokeCheckBox.Checked = false;
            A_FriedChickencheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_sideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckbox.Checked = false;
            B_carbonaracheckBox.Checked = false;
            B_Chickencheckbox.Checked = false;
            B_Friescheckbox.Checked = false;
            B_halohalocheckBox.Checked = false;
            B_HawaiiancheckBox.Checked = false;

            // clear textboxes
            priceTxtBox.Clear();
            discountTxtbox.Clear();
        }

        private void foodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (foodARdbtn.Checked)
            {
                // background color
                this.BackColor = Color.LightBlue;

                // image for A
                DisplayPictureBox.Image = Image.FromFile("C:\\Users\\acer\\source\\repos\\elaizabautista\\POS_Application-Bautista\\Images\\b1.jpg");

                // check A's items
                A_CokeCheckBox.Checked = true;
                A_FriedChickencheckBox.Checked = true;
                A_FriesCheckBox.Checked = true;
                A_sideDishCheckBox.Checked = true;
                A_SpecialPizzaCheckbox.Checked = true;

                // uncheck B's items
                B_carbonaracheckBox.Checked = false;
                B_Chickencheckbox.Checked = false;
                B_Friescheckbox.Checked = false;
                B_halohalocheckBox.Checked = false;
                B_HawaiiancheckBox.Checked = false;

                // price info
                priceTxtBox.Text = "P1,000.00";
                discountTxtbox.Text = "(20% of the Price) P200.00";
            }
        }

        private void foodBRdtn_CheckedChanged(object sender, EventArgs e)
        {
            if (foodBRdtn.Checked)
            {
                // background color
                this.BackColor = Color.LightPink;

                // image for B
                DisplayPictureBox.Image = Image.FromFile("C:\\Users\\acer\\source\\repos\\elaizabautista\\POS_Application-Bautista\\Images\\b2.jpg");

                // uncheck A's items
                A_CokeCheckBox.Checked = false;
                A_FriedChickencheckBox.Checked = false;
                A_FriesCheckBox.Checked = false;
                A_sideDishCheckBox.Checked = false;
                A_SpecialPizzaCheckbox.Checked = false;

                // check B's items
                B_carbonaracheckBox.Checked = true;
                B_Chickencheckbox.Checked = true;
                B_Friescheckbox.Checked = true;
                B_halohalocheckBox.Checked = true;
                B_HawaiiancheckBox.Checked = true;

                // price info
                priceTxtBox.Text = "P1,299.00";
                discountTxtbox.Text = "(15% of the Price) P194.85";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // uncheck bundles
            foodARdbtn.Checked = false;
            foodBRdtn.Checked = false;

            // reset image
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\acer\\source\\repos\\elaizabautista\\POS_Application-Bautista\\Images\\b13.jpg");

            // uncheck all items
            A_CokeCheckBox.Checked = false;
            A_FriedChickencheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_sideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckbox.Checked = false;
            B_carbonaracheckBox.Checked = false;
            B_Chickencheckbox.Checked = false;
            B_Friescheckbox.Checked = false;
            B_halohalocheckBox.Checked = false;
            B_HawaiiancheckBox.Checked = false;

            // clear textboxes
            priceTxtBox.Clear();
            discountTxtbox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the form
        }
    }
}
