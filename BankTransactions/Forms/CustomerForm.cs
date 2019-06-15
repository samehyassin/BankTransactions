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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnCustClose_Click(object sender, EventArgs e)
        {
            frmCustomer.ActiveForm.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCustomer.ActiveForm.Close();
        }
    }
}
