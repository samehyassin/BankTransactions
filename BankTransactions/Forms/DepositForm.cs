using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using BankTransactions;

namespace BankTransactions.Forms
{
    public partial class frmDeposit : Form
    {
        ApplicationContext db = new ApplicationContext();
        public frmDeposit()
        {
            InitializeComponent();
        }

       

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDbtSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDbtClose_Click(object sender, EventArgs e)
        {
            frmDeposit.ActiveForm.Close();
        }
    }
}
