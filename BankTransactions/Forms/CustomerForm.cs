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
using ClearTextbox;

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
                MessageBox.Show("Customer Added Successfully");
                Clear.ClearText(this);
            }
            FillCustGrid();
        }

        int CustId = 0;
        private void btnCustEdit_Click(object sender, EventArgs e)
        {
            //using (var context = new ApplicationDBContext())
            //{
            //    var customer = new Customer()
            //    {
            //        CustomerName = txtCustomerName.Update(),
            //        Phone = txtPhone.Update(),
            //        Mobile = txtPhone.Update(),
            //        Email = txtEmail.Update(),
            //        Address = txtAddress.Update(),
            //        TaxFileNumber = Convert.ToInt32(txtTaxFileNo.Update())
            //    };
            //}
        }


        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCustomer.Columns[0].Name = "CustId";
            dgvCustomer.Columns[1].Name = "Customr Name";
            dgvCustomer.Columns[2].Name = "Phone";
            dgvCustomer.Columns[3].Name = "Mobile";
            dgvCustomer.Columns[4].Name = "Email";
            dgvCustomer.Columns[5].Name = "Address";
            dgvCustomer.Columns[6].Name = "TaxFileNumber";
            if (dgvCustomer.SelectedRows.Count >0 && dgvCustomer.SelectedRows.Count<=1 )
            {
                CustId = (int)dgvCustomer.Rows[e.RowIndex].Cells[0].Value;
                txtCustomerName.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMobile.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
