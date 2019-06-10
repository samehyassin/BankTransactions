using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BankTransactions.Forms;

namespace BankTransactions
{
    public partial class frmEntryForm : Form
    {
        public frmEntryForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmEntryForm.ActiveForm.Dispose();
        }

        private void btnDebt_Click(object sender, EventArgs e)
        {
            frmDeposit debtfrom = new frmDeposit();
            debtfrom.ShowDialog();
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            frmWithdrawalForm withdfrom = new frmWithdrawalForm();
            withdfrom.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
