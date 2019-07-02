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
using BusinessLayer;
using ClearTextbox;
using DAL;

namespace BankTransactions.Forms
{
    public partial class frmCustomer : Form
    {
        int custId = 0;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            FillCustGrid();
            this.dgvCustomer.Columns["CustId"].Visible = false;
            dgvCustomer.Columns[0].Name = "CustId";
            dgvCustomer.Columns[1].Name = "Customr Name";
            dgvCustomer.Columns[2].Name = "Phone";
            dgvCustomer.Columns[3].Name = "Mobile";
            dgvCustomer.Columns[4].Name = "Email";
            dgvCustomer.Columns[5].Name = "Address";
            dgvCustomer.Columns[6].Name = "TaxFileNumber";
        }

        private void btnCustClose_Click(object sender, EventArgs e)
        {
            frmCustomer.ActiveForm.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCustomer.ActiveForm.Close();
        }


        public void FillCustGrid()
        {
            using (var context = new ApplicationDBContext())
            {
                dgvCustomer.DataSource = context.Customers.ToList();
            }
        }

        #region Inser Customer
        private void btnCustSave_Click(object sender, EventArgs e)
        {
            bool TaxFile = Int32.TryParse(txtTaxFileNo.Text, out int TaxFileNum);
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                Phone = txtPhone.Text,
                Mobile = txtMobile.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                TaxFileNumber = TaxFileNum
            };
            MessageBox.Show(new BLCustomer().CustomerInsert(customer));
            FillCustGrid();
            Clear.ClearText(this);
        }
        #endregion

        #region Update Customer
        private void btnCustEdit_Click(object sender, EventArgs e)
        {
            bool TaxFile = Int32.TryParse(txtTaxFileNo.Text, out int TaxFileNum);
            var customer = new Customer()
            {
                CustId = custId,
                CustomerName = txtCustomerName.Text,
                Phone = txtPhone.Text,
                Mobile = txtMobile.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                TaxFileNumber = TaxFileNum
            };

            MessageBox.Show(new BLCustomer().CustomerUpdate(customer));
            FillCustGrid();
            Clear.ClearText(this);
            btnCustSave.Enabled = true;
            btnCustDelete.Enabled = false;
            btnCustEdit.Enabled = false;
        } 
        #endregion

        #region Select from GridView
        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvCustomer.SelectedRows.Count > 0 && dgvCustomer.SelectedRows.Count <= 1)
            {
                custId = (int)dgvCustomer.Rows[e.RowIndex].Cells[0].Value;
                txtCustomerName.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMobile.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEmail.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTaxFileNo.Text = dgvCustomer.Rows[e.RowIndex].Cells[6].Value.ToString();

                btnCustSave.Enabled = false;
                btnCustDelete.Enabled = true;
                btnCustEdit.Enabled = true;
            }
        }
        #endregion

        #region Delete Customer
        private void btnCustDelete_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are You Sure Want to Delete This Customer  ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                bool TaxFile = Int32.TryParse(txtTaxFileNo.Text, out int TaxFileNum);
                var customer = new Customer()
                {
                    CustId = custId,
                    CustomerName = txtCustomerName.Text,
                    Phone = txtPhone.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    TaxFileNumber = TaxFileNum
                };
                MessageBox.Show(new BLCustomer().CustomerDelete(customer));
                FillCustGrid();
                Clear.ClearText(this);
                btnCustSave.Enabled = true;
                btnCustDelete.Enabled = false;
                btnCustEdit.Enabled = false;
            }
        } 
        #endregion

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
