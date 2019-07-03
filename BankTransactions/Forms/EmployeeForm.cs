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
using DAL;
using ClearTextbox;
using BusinessLayer;

namespace BankTransactions.Forms
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnEmpClose_Click(object sender, EventArgs e)
        {
            frmEmployee.ActiveForm.Close();
        }

        private void picbxEmpClose_Click(object sender, EventArgs e)
        {
            frmEmployee.ActiveForm.Close();       
        }
        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            var Employee = new Employee();
            {

            }
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
