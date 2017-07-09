using Microsoft.AspNetCore.Mvc;
using MySqlApi.DAL;

namespace MySqlApi.Controllers
{
    [Route("api/accounts")]
    public class AccountsController : Controller
    {        
        private AccountsRepository _repository;

        public AccountsController(AccountsRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {            
            var accounts = _repository.GetAll();

            return Ok(accounts);
        }
    }
}