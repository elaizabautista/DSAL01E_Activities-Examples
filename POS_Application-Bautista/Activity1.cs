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
    public partial class Activity1 : Form
    {
        public Activity1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to KKoppi_Co. - Cafe | Cakes | Pasta !!");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkRed; 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label2 clicked!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (itemnameTxtbox.Text.Length > 10)
            {
                MessageBox.Show("Order Saved !!");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            itemnameTxtbox.Clear();
            priceTxtbox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the form
        }

        private void americano_Click(object sender, EventArgs e)
        {
            // Assign values to the Text property of the textboxes
            itemnameTxtbox.Text = "Midnight Brew";
            priceTxtbox.Text = "120.50";
        }

        private void cortado_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Velvet Sunrise";
            priceTxtbox.Text = "105.20";
        }

        private void milkshake_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Creamy Chill Shake";
            priceTxtbox.Text = "150.90";
        }

        private void latte_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Heartstrings Latte";
            priceTxtbox.Text = "95.70";
        }

        private void mocha_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Choco Bliss Cup";
            priceTxtbox.Text = "80.90";
        }

        private void strawberryshortcake_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Berry Dream Slice";
            priceTxtbox.Text = "280.90";
        }

        private void carrotcake_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Golden Harvest Cake";
            priceTxtbox.Text = "190.50";
        }

        private void cheesecake_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Strawberry Serenade";
            priceTxtbox.Text = "120.50";
        }

        private void mochacake_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Choco Symphony";
            priceTxtbox.Text = "260.60";
        }

        private void chocolatecorissants_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Parisian Choco Twist";
            priceTxtbox.Text = "120.20";
        }

        private void pesto_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Verdant Basil Pesto";
            priceTxtbox.Text = "280.90";
        }

        private void spaghetti_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Roma Marinara";
            priceTxtbox.Text = "220.50";
        }

        private void parmesan_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Alfredo di Pollo";
            priceTxtbox.Text = "180.50";
        }

        private void carbonara_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Classic Carbonara Bianco";
            priceTxtbox.Text = "200.20";
        }

        private void rolly_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Fiery Napoli Pasta";
            priceTxtbox.Text = "310.50";
        } 
    }
}
