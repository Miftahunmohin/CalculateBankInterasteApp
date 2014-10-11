using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateBankInterasteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int time;
        private double balance;
        private double result;
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (bankComboBox.SelectedItem =="BRAC")
            {
                 time=Convert.ToInt32(timeTextBox.Text);
                 balance = Convert.ToDouble(balanceTextBox.Text);
                result = time*(balance*6/100);
                InterestTextBox.Text = result.ToString();
            }
           else if (bankComboBox.SelectedItem == "DBBL")
           {

               time = Convert.ToInt32(timeTextBox.Text);
               balance = Convert.ToDouble(balanceTextBox.Text);
               result = time * (balance * 7 / 100);
               InterestTextBox.Text = result.ToString();
           }
           //else if (bankComboBox.SelectedItem == "HSBC")
           else
           {
               time = Convert.ToInt32(timeTextBox.Text);
               balance = Convert.ToDouble(balanceTextBox.Text);
               result = time * (balance * 8 / 100);
               InterestTextBox.Text = result.ToString();  
           }
           
        }
    }
}
