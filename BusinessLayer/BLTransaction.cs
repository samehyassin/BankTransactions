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
    public class BLTransaction
    {
        private readonly ApplicationDBContext _context;
        public BLTransaction()
        {
            this._context = new ApplicationDBContext();
        }

        // Add Transaction
        public string TransactionInsert(Transaction transaction)
        {
                if (transaction.AmountAdded > 0)
                {
                    _context.Transactions.Add(transaction);
                    int result = _context.SaveChanges();
                    if (result > 0)
                    {
                        return "Deposit Added";
                    }
                    else
                    {
                        return "Deposit Failed";
                    }
                }
                else if(transaction.WithdrawalAmount > 0)
                {
                    transaction.WithdrawalAmount *= -1;
                    _context.Transactions.Add(transaction);
                    int result = _context.SaveChanges();

                    if (result > 0)
                    {
                        return "Withdraw Added";
                    }
                    else
                    {
                        return "Withdraw Failed";
                    }
                }
                else
                {
                    return "There Is Something Wrong";
                }
     
        }

        //Update
        public string TransactionUpdate (Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.Entry(transaction).State = EntityState.Modified;
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
        public string TransactionDelete(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.Entry(transaction).State = EntityState.Deleted;
            int result = _context.SaveChanges();
            if (result >0)
            {
                return "Transaction Was Deleted";
            }
            else
            {
                return "Failed to Delete Transaction";
            }
            _context.Dispose();
        }
    }
}
