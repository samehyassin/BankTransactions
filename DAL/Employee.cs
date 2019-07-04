using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
     public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }

        [MaxLength(100)]
        public string EmpName { get; set; }

        [MaxLength(50)]
        public string EmpTitle { get; set; }

        public int EmpMobile { get; set; }

        [MaxLength(1)]
        public string IsActive { get; set; }
    }
}
