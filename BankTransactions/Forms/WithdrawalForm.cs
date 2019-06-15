using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTransactions.Forms
{
    public partial class frmWithdrawalForm : Form
    {
        public frmWithdrawalForm()
        {
            InitializeComponent();
        }

        private void btnwthClose_Click(object sender, EventArgs e)
        {
            frmWithdrawalForm.ActiveForm.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmWithdrawalForm.ActiveForm.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
