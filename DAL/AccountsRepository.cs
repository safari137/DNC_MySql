using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MySqlApi.Models;

namespace MySqlApi.DAL
{
    public class AccountsRepository
    {
        private ApplicationDbContext _context;

        public AccountsRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Account> GetAll()
        {
            return _context.Accounts.ToList();
        }
    }
}