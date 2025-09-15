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
	public partial class Example5 : Form
	{
		//declaration of global variables
		private double amount_paid, price, cash_given, change;
		private int quantity;
		public Example5()
		{
			InitializeComponent();
		}

		private void newBtn_Click(object sender, EventArgs e)
		{
			// Clear the textboxes
			itemnameTxtbox.Clear();
			priceTxtbox.Clear();
			amount_PaidTxtbox.Clear();
			cash_givenTxtbox.Clear();
			changeTxtbox.Clear();
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			this.Close(); // closes the form
			priceTxtbox.Clear();
			amount_PaidTxtbox.Clear();
			cash_givenTxtbox.Clear();
			changeTxtbox.Clear();
		}

		private void americano_Click(object sender, EventArgs e)
		{
			// Assign values to the Text property of the textboxes
			itemnameTxtbox.Text = "Pizza 1";
			priceTxtbox.Text = "690.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
			priceTxtbox.Clear(); // code for the size of the form to be displayed once the program run

		}

		private void cortado_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 2";
			priceTxtbox.Text = "995.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void milkshake_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 3";
			priceTxtbox.Text = "800.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void latte_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 4";
			priceTxtbox.Text = "780.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void mocha_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 5";
			priceTxtbox.Text = "1000.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void chocolatecorissants_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 6";
			priceTxtbox.Text = "800.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void mochacake_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 7";
			priceTxtbox.Text = "780.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void cheesecake_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 8";
			priceTxtbox.Text = "1200.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void carrotcake_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 9";
			priceTxtbox.Text = "890.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void strawberryshortcake_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 10";
			priceTxtbox.Text = "550.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void pesto_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 11";
			priceTxtbox.Text = "500.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void spaghetti_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 12";
			priceTxtbox.Text = "750.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void parmesan_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 13";
			priceTxtbox.Text = "690.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double price;
			int quantity;
			double cashGiven;

			// check if price and quantity are valid numbers
			if (double.TryParse(priceTxtbox.Text, out price) && int.TryParse(qtyTxtbox.Text, out quantity))
			{
				amount_paid = price * quantity;
				amount_PaidTxtbox.Text = amount_paid.ToString("n");

				// check if cash given is valid before calculating change
				if (double.TryParse(cash_givenTxtbox.Text, out cashGiven))
				{
					change = cashGiven - amount_paid;
					changeTxtbox.Text = change.ToString("n");
				}
				else
				{
					changeTxtbox.Clear(); // no cash given yet
				}
			}
			else
			{
				amount_PaidTxtbox.Clear();
				changeTxtbox.Clear();
			}
		}

		private void qtyTxtbox_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(priceTxtbox.Text) && !string.IsNullOrWhiteSpace(qtyTxtbox.Text))
			{
				double price;
				int quantity;

				if (double.TryParse(priceTxtbox.Text, out price) && int.TryParse(qtyTxtbox.Text, out quantity))
				{
					amount_paid = price * quantity;
					amount_PaidTxtbox.Text = amount_paid.ToString("n");
				}
				else
				{
					amount_PaidTxtbox.Clear(); // clear if invalid input
				}
			}
			else
			{
				amount_PaidTxtbox.Clear();
			}
		}

		private void carbonara_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 14";
			priceTxtbox.Text = "790.50";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void rolly_Click(object sender, EventArgs e)
		{
			itemnameTxtbox.Text = "Pizza 15";
			priceTxtbox.Text = "800.90";
			priceTxtbox.Focus(); // code for where the cursor take place after clicking the picturebox
		}

		private void Example5_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Welcome to KKoppi_Co. - Pizza !!");
			changeTxtbox.Enabled = false; // code for disabling the textbox
			this.Location = new Point(0, 0); // code for the location of the form once the program run by x and y axis
			this.Size = Screen.PrimaryScreen.WorkingArea.Size; //code for the size of the form to be displayed once the program run
		}
	}
}
