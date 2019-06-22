using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DAL;

namespace BusinessLayer
{
    //public bool UpdateStudentDetails(StudentDetail Stu) // UpdateStudentDetails method for update a existing Record
    //{
    //    bool result = false;
    //    using (StudentInformationEntities _entity = new StudentInformationEntities())
    //    {
    //        StudentDetail _student = _entity.StudentDetails.Where(x => x.Id == Stu.Id).Select(x => x).FirstOrDefault();
    //        _student.Name = Stu.Name;
    //        _student.Age = Stu.Age;
    //        _student.City = Stu.City;
    //        _student.Gender = Stu.Gender;
    //        _entity.SaveChanges();
    //        result = true;
    //    }
    //    return result;
    //}
    public class BLCustomer
    {
        //bool result = false;
        
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
    }
}
