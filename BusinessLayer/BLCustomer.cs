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
    public class BLCustomer
    {
        private readonly ApplicationDBContext _context;

        public BLCustomer()
        {
            this._context = new ApplicationDBContext();
        }

        //Insert
        public string CustomerInsert(Customer customer)
        {
            
                _context.Customers.Add(customer);
                int result = _context.SaveChanges();
                if(result > 0)
                {
                    return "Inserted Successfully";
                }
                else
                {
                    return "Failed to Insert";
                } 
        }

        //Update
        public string CustomerUpdate(Customer customer)
        { 
                     _context.Customers.Add(customer);
                     _context.Entry(customer).State = EntityState.Modified;
                     int check = _context.SaveChanges();
                     _context.Dispose();
              
                if (check > 0)
                {
                    return "Updated";
                }
                else
                {
                    return "failed to Update";
                }
            
        }

        //Delete
        public string CustomerDelete(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.Entry(customer).State = EntityState.Deleted;
            
                int result = _context.SaveChanges();
                if (result > 0)
                {
                    return "Customer was Deleted";
                }
                else
                {
                    return "Failed for Delete Customer";
                }
            _context.Dispose();
        }
    }
}
