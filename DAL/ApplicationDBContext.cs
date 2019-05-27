using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext()
            : base("Data Source=.; Initial Catalog=BankTransactionsDB; Integrated Security=true")
        {
            
        }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().Property(d => d.InvoiceAmount).HasPrecision(9, 2);
            modelBuilder.Entity<Transaction>().Property(p => p.AmountAdded).HasPrecision(9, 2);
            modelBuilder.Entity<Transaction>().Property(e => e.SalesRecieptAmount).HasPrecision(9, 2);
            modelBuilder.Entity<Transaction>().Property(m => m.WithdrawalAmount).HasPrecision(9, 2);
  
            base.OnModelCreating(modelBuilder);
        }
    }
}
