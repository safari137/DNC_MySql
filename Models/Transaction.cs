using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MySqlApi.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }

        public string Description { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}