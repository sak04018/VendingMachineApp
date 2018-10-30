using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VendingMachineApp
{

        static class VendingMachine
    {

        private static VendingModel db = new VendingModel();
        
        public static Transaction NewTransaction(string selection, string snackName)
        {
            var transaction = new Transaction()
            {
                Selection = selection,
                SnackName = snackName 
            };

            transaction.DepositMoney(selection);

            db.Transactions.Add(transaction);
            db.SaveChanges();
            return transaction;
        }
        
    }
}
