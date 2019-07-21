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
using DAL;
using ClearTextbox;

namespace BankTransactions.Forms
{
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

       

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            PaymentMethodcbx();
            CustomerNamecbx();
            EmployeeNamecbx();
        }

        private void btnDbtClose_Click(object sender, EventArgs e)
        {
            frmDeposit.ActiveForm.Close();
        }

        #region Employee Name Method 
        public void EmployeeNamecbx()
        {
            using (var context = new ApplicationDBContext())
            {
                var employees = context.Employees.ToList();

                cbxEmployeeName.DataSource = employees;
                cbxEmployeeName.DisplayMember = "EmpName";
                cbxEmployeeName.ValueMember = "EmpId";
            }
        } 
        #endregion

        #region Customer Name Method 
        public void CustomerNamecbx()
        {
            using (var context = new ApplicationDBContext())
            {
                var customers = context.Customers.ToList();

                cbxCustomerName.DataSource = customers;
                cbxCustomerName.DisplayMember = "CustomerName";
                cbxCustomerName.ValueMember = "CustId";
            }
        } 
        #endregion

        #region Payment Method Combobox
        public void PaymentMethodcbx()
        {
            using (var context = new ApplicationContext())
            {
                cbxPaymentMethod.DisplayMember = "Check";
                cbxPaymentMethod.DisplayMember = "Cash";
            }
        } 
        #endregion
        
        private void btnDbtSave_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDBContext())
            {
                bool InvoiceNumber = Int32.TryParse(txtInvoiceNumber.Text, out int InvoiceNum);
                bool SalesReciptNumber = Int32.TryParse(txtSalesReceiptno.Text, out int SalesRecipNum);
                bool CheckNumber = Int32.TryParse(txtCheckNumber.Text, out int CheckNum);
                bool RefNumber = Int32.TryParse(txtRefNumber.Text, out int RefNum);
                bool InvoiceAmount = decimal.TryParse(txtInvoiceAmount.Text, out decimal InvAmount);
                bool AmountAdded = decimal.TryParse(txtAmountAdded.Text, out decimal AmAdded);
                var trans = new Transaction()
                {
                    DepositDate = dtpDepositDate.Value,

                    //InvoiceNumber = Convert.ToInt32(txtInvoiceNumber.Text),
                    InvoiceNumber = InvoiceNum,

                    //InvoiceAmount = Convert.ToDecimal(txtInvoiceNumber.Text),
                    InvoiceAmount = InvAmount,

                    //AmountAdded = Convert.ToDecimal(txtAmountAdded.Text),
                    AmountAdded = AmAdded,

                    //SalesReceiptNumber = Convert.ToInt32(txtSalesReceiptno.Text),
                    SalesReceiptNumber = SalesRecipNum,

                    PaymentMethod = cbxPaymentMethod.ValueMember,
                    //CheckNumber = Convert.ToInt32(txtCheckNumber.Text),
                    CheckNumber = CheckNum,

                    //RefNumber = Convert.ToInt32(txtRefNumber.Text),
                    RefNumber = RefNum,

                    EmpId = Convert.ToInt32(cbxEmployeeName.SelectedValue),
                    CustId = Convert.ToInt32(cbxCustomerName.SelectedValue)
                };
                MessageBox.Show(new BLTransaction().TransactionInsert(trans));
                Clear.ClearText(this);
                btnDbtSave.Enabled = true;
                btnDbtUpdate.Enabled = false;
                btnDbtDelete.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmCustomer custfrom = new frmCustomer();
            custfrom.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmDeposit.ActiveForm.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbxEmployeeName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string x = cbxEmployeeName.SelectedText;
            int y = Convert.ToInt16(cbxEmployeeName.SelectedValue);
        }

        private void picbxAddEmp_Click(object sender, EventArgs e)
        {
            frmEmployee empfrm = new frmEmployee();
            empfrm.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmTransactions frmTrans = new frmTransactions();
            frmTrans.ShowDialog();
        }
    }
}
