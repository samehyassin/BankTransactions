using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BusinessLayer
{
    public class BLTransaction
    {
        public string TransInsert(Transaction transaction)
        {
            using (var context = new ApplicationDBContext())
            {
                if (transaction.AmountAdded > 0)
                {
                    context.Transactions.Add(transaction);
                    int result = context.SaveChanges();
                    if (result > 0)
                    {
                        return "deposit added";
                    }
                    else
                    {
                        return "deposit failed";
                    }
                }
                else if(transaction.WithdrawalAmount > 0)
                {
                    transaction.WithdrawalAmount *= -1;
                    context.Transactions.Add(transaction);
                    int result = context.SaveChanges();

                    if (result > 0)
                    {
                        return "withdraw added";
                    }
                    else
                    {
                        return "withdraw failed";
                    }
                }
                else
                {
                    return "something wrong";
                }
                
            }
            
        }
    }
}
