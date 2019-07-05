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
        int empId = 0;

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            FillEmpGrid();
            dgvEmp.Columns[0].Name = "Employee Name";
            dgvEmp.Columns[1].Name = "Title";
            dgvEmp.Columns[2].Name = "Mobile";
        }

        //Close Form
        private void btnEmpClose_Click(object sender, EventArgs e)
        {
            frmEmployee.ActiveForm.Close();
        }

        //Fill GridView Function
        public void FillEmpGrid()
        {
            using (var context = new ApplicationDBContext())
            {
                dgvEmp.DataSource = context.Employees.ToList();
            }
        }
        //Close Form
        private void picbxEmpClose_Click(object sender, EventArgs e)
        {
            frmEmployee.ActiveForm.Close();
        }
        
        //Insert Employee
        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            bool EmpMobile = Int32.TryParse(txtEmpMobile.Text, out int empMobile);
            var employee = new Employee()
            {
                EmpName = txtEmpName.Text,
                EmpTitle = txtEmpTitle.Text,
                EmpMobile = empMobile
                
            };
            MessageBox.Show(new BLEmployee().EmployeeInsert(employee));
            FillEmpGrid();
            Clear.ClearText(this);
            btnEmpSave.Enabled = true;
            btnEmpEdit.Enabled = false;
            btnEmpDelete.Enabled = false;
        }
        //Select form GridView
        private void dgvEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmp.SelectedRows.Count > 0 && dgvEmp.SelectedRows.Count <=1)
            {
                empId = (int)dgvEmp.Rows[e.RowIndex].Cells[0].Value;
                txtEmpName.Text = dgvEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEmpTitle.Text = dgvEmp.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmpMobile.Text = dgvEmp.Rows[e.RowIndex].Cells[3].Value.ToString();

                btnEmpSave.Enabled = false;
                btnEmpEdit.Enabled = true;
                btnEmpDelete.Enabled = true;
            }
        }

        //Update Employee
        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            bool EmpMobile = Int32.TryParse(txtEmpMobile.Text, out int empMobile);
            var emp = new Employee()
            {
                EmpId = empId,
                EmpName = txtEmpName.Text,
                EmpMobile = empMobile,
                EmpTitle = txtEmpTitle.Text
            };

            MessageBox.Show(new BLEmployee().EmployeeUpdate(emp));
            FillEmpGrid();
            Clear.ClearText(this);
            btnEmpSave.Enabled = false;
            btnEmpEdit.Enabled = true;
            btnEmpDelete.Enabled = false;
        }

        //Delete Employee
        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are You Sure Want to Delete This Employee ?", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                bool EmpMobile = Int32.TryParse(txtEmpMobile.Text, out int empMobile);
                var emp = new Employee()
                {
                    EmpId = empId,
                    EmpName = txtEmpName.Text,
                    EmpTitle = txtEmpTitle.Text,
                    EmpMobile = empMobile
                };
                MessageBox.Show(new BLEmployee().EmployeeDelete(emp));
                FillEmpGrid();
                Clear.ClearText(this);
                btnEmpSave.Enabled = false;
                btnEmpEdit.Enabled = true;
                btnEmpDelete.Enabled = true;
            }
        }
    }
}
