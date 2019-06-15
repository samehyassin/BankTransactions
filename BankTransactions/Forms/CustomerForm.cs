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
using DAL;

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

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            FillCustGrid();
        }
        public void FillCustGrid()
        { 
        using (var context = new ApplicationDBContext())
            {
                dgvCustomer.DataSource = context.Customers.ToList();
            }
        }

        private void btnCustSave_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDBContext())
            {
                var customer = new Customer()
                {
                   CustomerName = txtCustomerName.Text,
                   Phone = txtPhone.Text,
                   Mobile = txtMobile.Text,
                   Email = txtEmail.Text,
                   Address = txtAddress.Text,
                   TaxFileNumber = Convert.ToInt32(txtTaxFileNo.Text)
                };
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            FillCustGrid();
        }
    }
}
