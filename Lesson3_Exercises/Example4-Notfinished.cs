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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            foodARdbtn.CheckedChanged += foodARdbtn_CheckedChanged;
            //foodBRdtn.CheckedChanged += foodBRdtn_CheckedChanged;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            priceTxtBox.Enabled = false;
            discountedamountTxtbox.Enabled = false;
            changeTxtbox.Enabled = false;
            totalBillsTxtbox.Enabled = false;
            discountamountTxtbox.Enabled = false;
            totalQtyTxtbox.Enabled = false;

            A_CokeCheckBox.Enabled = false;
            A_FriedChickencheckBox.Enabled = false;
            A_FriesCheckBox.Enabled = false;
            A_sideDishCheckBox.Enabled = false;
            A_SpecialPizzaCheckbox.Enabled = false;
            B_carbonaracheckBox.Enabled = false;
            B_Chickencheckbox.Enabled = false;
            B_halohalocheckBox.Enabled = false;
            B_HawaiiancheckBox.Enabled = false;
        }

        private void foodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            //code for changing the form background color
            this.BackColor = Color.LightCyan;
            //code for food bundle B not to be selected
            foodBRdtn.Checked = false;
            //inserting image inside the picture box
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\b13.jpg");
            //codes to check the checkboxes
            A_CokeCheckBox.Checked = true;
            A_FriedChickencheckBox.Checked = true;
            A_FriesCheckBox.Checked = true;
            A_sideDishCheckBox.Checked = true;
            A_SpecialPizzaCheckbox.Checked = true;
            //codes to uncheck the checkboxes
            B_carbonaracheckBox.Checked = false;
            B_Chickencheckbox.Checked = false;
            B_Friescheckbox.Checked = false;
            B_halohalocheckBox.Checked = false;
            B_HawaiiancheckBox.Checked = false;
            //codoes for displaying data inside the textboxes
            priceTxtBox.Text = "1,000";
            discountamountTxtbox.Text = "200.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            //codes for inserting data inside a listbox
            displayListbox.Items.Add(foodBRdtn.Text + "" + priceTxtBox.Text);
            displayListbox.Items.Add("");
        }
    }
}
