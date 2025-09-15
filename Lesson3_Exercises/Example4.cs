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
    public partial class Example4 : Form
    {
        //Class level variables (fields)
        int total_qty = 0;
        double total_amount = 0;

        public Example4()
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
            this.BackColor = Color.LightPink;
            //code for food bundle B not to be selected
            foodBRdtn.Checked = false;
            //inserting image inside the picture box
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\b1.jpg");
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
            displayListbox.Items.Add(foodBRdtn.Text + "              " + priceTxtBox.Text);
            displayListbox.Items.Add("       Discount Amount:" + "               " + discountamountTxtbox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void foodBRdtn_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            foodARdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\b2.jpg");
            A_CokeCheckBox.Checked = false;
            A_FriedChickencheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_sideDishCheckBox.Checked = false;
            A_SpecialPizzaCheckbox.Checked = false;
            B_carbonaracheckBox.Checked = true;
            B_Chickencheckbox.Checked = true;
            B_Friescheckbox.Checked = true;
            B_halohalocheckBox.Checked = true;
            B_HawaiiancheckBox.Checked = true;
            priceTxtBox.Text = "1,299";
            discountamountTxtbox.Text = "(15% of the Price) P194.85";
            displayListbox.Items.Add(foodARdbtn.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double cash_given, change, total_amountPaid;
            cash_given = Convert.ToDouble(cashGivenTxtbox.Text);
            total_amountPaid = Convert.ToDouble(totalBillsTxtbox.Text);
            change = cash_given - total_amountPaid;
            changeTxtbox.Text = change.ToString("n");
            displayListbox.Items.Add("Total Bills: " + "              " + totalBillsTxtbox.Text);
            displayListbox.Items.Add("Cash Given: " + "              " + cashGivenTxtbox.Text);
            displayListbox.Items.Add("Change: " + "              " + changeTxtbox.Text);
            displayListbox.Items.Add("Total No. of Items: " + "              " + totalQtyTxtbox.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // create instance of the other form
            PrintForm print = new PrintForm();

            // copy items from current form's listbox to the other form's listbox
            print.Listbox1.Items.AddRange(displayListbox.Items); //make sure to see the Listbox1 is public (under modifiers) in the PrintForm

            // show the other form
            print.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //codes to remove the selected data inside the listbox
            displayListbox.Items.RemoveAt (displayListbox.SelectedIndex );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //codes to uncheck all given checkboxes
            foodARdbtn.Checked = false;
            foodBRdtn.Checked = false;
            //code for inserting default image inside the picture box
            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\b13.jpg");
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
            //codes for clearing the textboxes
            priceTxtBox.Clear();
            qtyTxtbox.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            //removing the contents of a listbox
            displayListbox.Items.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            // If empty or invalid, just exit
            if (string.IsNullOrWhiteSpace(qtyTxtbox.Text)) return;

            double price, discounted_amount, discount_amount;
            int qty;

            try
            {
                price = Convert.ToDouble(priceTxtBox.Text);
                qty = Convert.ToInt32(qtyTxtbox.Text);
                discount_amount = Convert.ToDouble(discountamountTxtbox.Text);

                discounted_amount = (price * qty) - discount_amount;

                total_qty += qty;
                totalQtyTxtbox.Text = total_qty.ToString();

                total_amount += discounted_amount;
                totalBillsTxtbox.Text = discounted_amount.ToString("n");
                discountedamountTxtbox.Text = discounted_amount.ToString("n");
            }
            catch
            {
                // Optional: clear if invalid entry
                qtyTxtbox.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //codes to declare a variable with specific data type
            double price;
            //codes for putting text property value of the textbox
            discountamountTxtbox.Text = "0.00";
            priceTxtBox.Text = "500.99";
            //codes to convert string data inside the textbox to numeric data to store inside the variable
            price = Convert.ToDouble(priceTxtBox.Text);
            //codes to insert text property value of a checkbox inside the listbox
            displayListbox.Items.Add(checkBox1.Text + "              " + priceTxtBox.Text);
            //codes for putting text property value of the textbox
            qtyTxtbox.Text = "0";
            //codes for the cursor inside the textbox once the event of the object triggered
            qtyTxtbox.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "550.00";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox2.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "600.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox3.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "700.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox4.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "750.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox5.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "650.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox6.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "600.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox7.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "550.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox8.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "500.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox9.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "450.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox10.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();  
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "400.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox11.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "780.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox12.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "820.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox13.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "880.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox14.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "920.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox15.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";  
            qtyTxtbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            double price;   
            priceTxtBox.Text = "780.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox16.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "800.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox17.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "850.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox18.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            double price;   
            priceTxtBox.Text = "900.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox19.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "950.99";
            discountamountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox20.Text + "              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }
    }
}
