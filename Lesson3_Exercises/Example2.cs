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
    public partial class Example2 : Form
    {
        public Example2()
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
            pictureBox16.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\a16.jpg");
            pictureBox17.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Imagesa17.jpg");
            pictureBox18.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\a18.jpg");
            pictureBox19.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\a19.jpg");
            pictureBox20.Image = Image.FromFile("C:\\Users\\Bautista\\source\\repos\\elaizabautista\\final2_visualstudio_form123\\Lesson3_Exercises\\Images\\a20.jpg");

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

            quantitytxtbox.Text = "0";
            pricetextbox.Text = "0";
            discounttxtbox.Text = "0";
            discountedtxtbox.Text = "0";
            cashrenderedtxtbox.Text = "0";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            //convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            //Create a formula needed for computation
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            //codes for unchecking the other radio buttons in the interface once the senior citizen method is executed
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            //convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            //create a formula needed for computation
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            //codes for unchecking the other radio buttons in the interface once the disc. Card is executed
            radioButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            //convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            //create a formula needed for computation
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            //codes for unchecking the other radio buttons in the interface once the Employee disc is executed
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }
        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            //Declaration of variables within a method of an object
            int qty;
            double price, discount_amt, discounted_amt;
            //convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            //create a formula needed for computation
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;
            //converting numeric data to string and display it inside the textboxes
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            //codes for unchecking the other radio buttons in the interface once the no method is executed
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            noTaxRdbtn.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaration of variables with data types
            int qty;
            double discount_amt, discounted_amt, cash_rendered, change;
            qty = Convert.ToInt32(quantitytxtbox.Text);
            discount_amt = Convert.ToDouble(discounttxtbox.Text);
            discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
            cash_rendered = Convert.ToDouble(cashrenderedtxtbox.Text);
            //codes to accumulate the value of the quantity, discount given and discounted amount from one transaction to another
            qty_totaltxtbox.Text += qty;
            discount_totaltxtbox.Text += discount_amt;
            discounted_totaltxtbox.Text += discounted_amt;
            change = cash_rendered - discounted_amt;
            //convert string data form textboxes to numeric and place it as value of the variable
            qty_totaltxtbox.Text = qty.ToString();
            discount_totaltxtbox.Text = discount_amt.ToString("n");
            discounted_totaltxtbox.Text = discounted_amt.ToString("n");
            changetxtbox.Text = change.ToString("n");
            cashrenderedtxtbox.Text = cash_rendered.ToString("n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //code for closing the form application once the button is clicked
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //codes for clearing specific pointed textboxes
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashrenderedtxtbox.Clear();
        }

        private void americano_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = "Midnight Brew";
            pricetextbox.Text = "120.90";
        }

        private void cortado_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = "Velvet Sumrise";
            pricetextbox.Text = "150";
        }

        private void milkshake_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = "Creamy Chill Shake";
            pricetextbox.Text = "180.90";
        }

        private void latte_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name4lbl.Text;
            pricetextbox.Text = "200";
        }

        private void mocha_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name5lbl.Text;
            pricetextbox.Text = "220.50";
        }

        private void strawberryshortcake_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name6lbl.Text;
            pricetextbox.Text = "250.05";
        }

        private void carrotcake_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name7lbl.Text;
            pricetextbox.Text = "300.45";
        }

        private void cheesecake_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name8lbl.Text;
            pricetextbox.Text = "350.30";
        }

        private void mochacake_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name9lbl.Text;
            pricetextbox.Text = "400.40";
        }

        private void chocolatecorissants_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name10lbl.Text;
            pricetextbox.Text = "450.50";
        }

        private void pesto_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name11lbl.Text;
            pricetextbox.Text = "300.45";
        }

        private void spaghetti_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name12lbl.Text;
            pricetextbox.Text = "350.30";
        }

        private void carbonara_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name13lbl.Text;
            pricetextbox.Text = "400.50";
        }

        private void parmesan_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name14lbl.Text;
            pricetextbox.Text = "450.60";
        }

        private void rolly_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name15lbl.Text;
            pricetextbox.Text = "500.70";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name16lbl.Text;
            pricetextbox.Text = "600.10";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = namel17lbl.Text;
            pricetextbox.Text = "550.25";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name18lbl.Text;
            pricetextbox.Text = "500.60";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name19lbl.Text;
            pricetextbox.Text = "450.90";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //codes for inserting value of TEXT property of a textbox (item namne & price)
            itemnametxtbox.Text = name20lbl.Text;
            pricetextbox.Text = "890.90";
        }

        private void name1lbl_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to the current form
            Example2 print = new Example2();
            //codes for displaying the contents of the listbox from other form to the current form.
            print.printdisplayListbox.Items.AddRange(displaylistbox.Items);
            //code for displaying other form
            print.Show();
        }

        private void displaylistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaylistbox.Items.Add(itemnametxtbox.Text);
            displaylistbox.Items.Add(pricetextbox.Text);
            displaylistbox.Items.Add(discounttxtbox.Text);
            displaylistbox.Items.Add(discountedtxtbox.Text);
            displaylistbox.Items.Add(discounted_totaltxtbox.Text);
            displaylistbox.Items.Add(qty_totaltxtbox.Text);
            displaylistbox.Items.Add(discounted_totaltxtbox.Text);
            displaylistbox.Items.Add(discount_totaltxtbox.Text);
            displaylistbox.Items.Add(changetxtbox.Text);
        }
    }
}