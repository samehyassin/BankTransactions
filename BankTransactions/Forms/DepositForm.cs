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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

       

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            PaymentMethodCbx();
            CusterNamecbx();
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
                cbxEmployeeName.DisplayMember = "EmployeeName";
                cbxEmployeeName.ValueMember = "EmpId";
            }
        } 
        #endregion

        #region Customer Name Method 
        public void CusterNamecbx()
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
        public void PaymentMethodCbx()
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
            //using (var context = new ApplicationDBContext())
            //{
            //      var trans = new Transaction()
            //      {
            //        DepositDate = dtpDepositDate.Value,
            //        InvoiceNumber = Convert.ToInt32(txtInvoiceNumber.Text),
            //        InvoiceAmount = Convert.ToDecimal(txtInvoiceNumber.Text),
            //        AmountAdded = Convert.ToDecimal(txtAmountAdded.Text),
            //        SalesReceiptNumber = Convert.ToInt32(txtSalesReceiptno.Text),
            //        PaymentMethod = cbxPaymentMethod.Text,
            //        CheckNumber = Convert.ToInt32(txtCheckNumber.Text),
            //        RefNumber = Convert.ToInt32(txtRefNumber.Text),
            //        EmpId = Convert.ToInt32(cbxEmployeeName.SelectedValue),
            //        CustId = Convert.ToInt32(cbxCustomerName.SelectedValue)
            //      };
            //    context.Transactions.Add(trans);
            //    context.SaveChanges();
            //}
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
    }
}
