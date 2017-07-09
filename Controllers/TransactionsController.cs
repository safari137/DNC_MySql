using Microsoft.AspNetCore.Mvc;
using MySqlApi.DAL;
using MySqlApi.Models;
using Newtonsoft.Json;

namespace MySqlApi.Controllers
{   
    [Route("api/transactions")] 
    public class TransactionsController : Controller
    {
        private TransactionRepository repository;
        
        public TransactionsController(TransactionRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAllTransactions());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(repository.GetTransactionById(id));
        }

        [HttpPut]
        public IActionResult Update([FromBody]Transaction transaction)
        {
            repository.UpdateTransaction(transaction);
            return Accepted();
        }

        [HttpPost]
        public IActionResult Insert([FromBody]Transaction transaction)
        {
            System.Console.WriteLine(transaction.ToJson());
            repository.AddTransaction(transaction);
            return Created("", null);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repository.DeleteTransaction(id);
            return NoContent();
        }
    }
}