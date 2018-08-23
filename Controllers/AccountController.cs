using System;
using System.Collections.Generic;
using System.Linq;
using InstCoreRest.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstCoreRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly InstDbContext _context;

        public AccountController(InstDbContext context)
        {
            _context = context;

            if (_context.Accounts.Count() == 0)
            {
                _context.Accounts.Add(new Account { Login = "user", Password="pass"});
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Account>> GetAll()
        {
            return _context.Accounts.ToList();
        }
    }
}
