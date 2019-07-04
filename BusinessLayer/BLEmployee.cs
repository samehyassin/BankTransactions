using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//
using DAL;

namespace BusinessLayer
{
    public class BLEmployee
    {
        private readonly ApplicationDBContext _context;
        public BLEmployee()
        {
            this._context = new ApplicationDBContext();
        }
        //Insert
        public string EmployeeInsert(Employee employee)
        {
            _context.Employees.Add(employee);
            int result = _context.SaveChanges();
            if(result > 0)
            {
                return "Inserted Successfully";
            }
            else
            {
                return "Faild To Inserted";
            }
        }

        //Update
        public String EmployeeUpdate(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.Entry(employee).State = EntityState.Modified;
            int check = _context.SaveChanges();
            _context.Dispose();
            if (check > 0)
            {
                return "Updated";
            }
            else
            {
                return "Failed To Update";
            }
        }

        //Delete
        public string EmployeeDelete(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.Entry(employee).State = EntityState.Deleted;

            int result = _context.SaveChanges();
            if (result > 0)
            {
                return "Employee Was Deleted";
            }
            else
            {
                return "Failed For Delete Employee";
            }
            _context.Dispose();
        }

    }
}
