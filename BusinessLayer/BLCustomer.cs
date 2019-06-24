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
        //Insert
        public string CustomerInsert(Customer customer)
        {
            using (var context = new ApplicationDBContext())
            {
                context.Customers.Add(customer);
                int result = context.SaveChanges();
                if(result > 0)
                {
                    return "Inserted Successfully";
                }
                else
                {
                    return "Failed to Insert";
                }
            }
        }

        //Update
        public string CustomerUpdate(Customer customer)
        {
            using (var context = new ApplicationDBContext())
            {
                context.Customers.Add(customer);
                context.Entry(customer).State = EntityState.Modified;
                context.Customers.Add(customer);
                int result = context.SaveChanges();
                if (result > 0)
                {
                    return "Updated";
                }
                else
                {
                    return "failed to Update";
                }
            }
        }

        //Delete
        public string CustomerDelete(Customer customer)
        {
            using (var context =  new ApplicationDBContext())
            {
                context.Entry(customer).State = EntityState.Deleted;
                int result = context.SaveChanges();
                if (result > 0)
                {
                    return "Customer was Deleted";
                }
                else
                {
                    return "Failed for Delete Customer";
                }
            }
        }
    }
}
