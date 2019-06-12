using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransId { get; set; } 

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public int InvoiceNumber { get; set; }
        [Required]
        public decimal InvoiceAmount { get; set; }

        [Required]
        public decimal AmountAdded { get; set; }

        public int SalesReceiptNumber { get; set; }

        public decimal SalesRecieptAmount { get; set; }

        public string PaymentMethod { get; set; }

        public int CheckNumber { get; set; }

        public int RefNumber { get; set; }

        public decimal WithdrawalAmount { get; set; }

        public int WithdRefNumber { get; set; }

        [MaxLength(300)]
        public string Note { get; set; }

        [ForeignKey("Employee")]
        public int EmpId { get; set; }
        
        public Employee Employee { get; set; }

        [ForeignKey("Customer")]
        public int CustId { get; set; }

        public Customer Customer { get; set; }

    }
}
