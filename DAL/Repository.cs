using System.Collections.Generic;
using System.Linq;
using MySqlApi.Models;

namespace MySqlApi.DAL
{
    public class Repository
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _context.Transactions;
        }

        public Transaction GetTransactionById(int id)
        {
            return _context.Transactions.FirstOrDefault(t => t.Id == id);
        }

        public void AddTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            if (this.GetTransactionById(transaction.Id) != null) {
                _context.Transactions.Update(transaction);            
                _context.SaveChanges();
            }
        }

        public void DeleteTransaction(int id)
        {
            var transaction = this.GetTransactionById(id);

            if (transaction == null) { return; }

            _context.Transactions.Remove(transaction);
            _context.SaveChanges();
        }
    }
}