/*Daniel Lundy 03/10/2020
 * The purpose of this program is to demonstrate a Windows form application with input validation.
 * The form calculates monthly loan payments and requires all text boxes to have a value entered by the user.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Exercise4
{
    public partial class Main : Form
    {
       

        public Main()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("The inputs on this form cannot be empty.");


                }
                else
                {
                    double price = Convert.ToDouble(textBox1.Text);
                    double downPayment = Convert.ToDouble(textBox2.Text);
                    double interestRate = Convert.ToDouble(textBox3.Text);
                    int loanTerms = Convert.ToInt32(textBox4.Text);
                    double monthlyInterest = (interestRate / 100) / 12;
                    double financeAmount = price - downPayment;
                    textBox5.Text = financeAmount.ToString("C2");
                    double monthlyPayment = (monthlyInterest * financeAmount) * (Math.Pow(1 + monthlyInterest, loanTerms)) / (Math.Pow(1 + monthlyInterest, loanTerms) - 1);
                    textBox6.Text = monthlyPayment.ToString("C2");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




 