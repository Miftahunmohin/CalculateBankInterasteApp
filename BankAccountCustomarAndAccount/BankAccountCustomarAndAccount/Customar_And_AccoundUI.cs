using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountCustomarAndAccount
{
    public partial class Customar_And_AccoundUI : Form
    {
        private Customar aCustomar;

        public Customar_And_AccoundUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.number = accountNumberEntryTextBox.Text;
            account.openingDate = openingDateTextBox.Text;

            aCustomar = new Customar();
            aCustomar.name = nameEntryTextBox.Text;
            aCustomar.email = emailEntryTextBox.Text;
             aCustomar.AnAccount = account;

            MessageBox.Show(@"Account has been Created");

        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amontTextBox.Text);
            aCustomar.AnAccount.deposite(amount);
            MessageBox.Show(@"Desosite Succes");
            amontTextBox.Text= String.Empty;
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amontTextBox.Text);
            aCustomar.AnAccount.withdraw(amount);
            MessageBox.Show(@"Withdraw Succes");
            amontTextBox.Text = string.Empty;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            customarNameShowTextBox.Text = aCustomar.name;
            emailShowTextBox.Text = aCustomar.email;
            accountNumberShowTextBox.Text = aCustomar.AnAccount.number;
            openingDateShowTextBox.Text = aCustomar.AnAccount.openingDate;
            balanceTextBox.Text = aCustomar.AnAccount.balance.ToString();
        }

       
    }
}
