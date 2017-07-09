using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MySqlApi.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}