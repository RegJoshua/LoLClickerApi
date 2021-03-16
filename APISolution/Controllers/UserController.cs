using APISolution.Entities;
using APISolution.FirstDbModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISolution.Controllers
{
    [ApiController]
    [Route("v2/[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly ApiContext _context;

        public UserController(ILogger<UserController> logger, ApiContext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// Gets Users from User table
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            List<User> userList = _context.Set<User>().AsNoTracking().ToList();
            return userList;
        }
    }
}
