using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        // [HttpGet]
        // public ActionResult<IEnumerable<AppUser>> GetUsers(){
        //     // var Users=_context.Users.ToList();
        //     // return Users;
        //     return _context.Users.ToList();
        // }

        //Get User Details
        //api/Controller/id
        // [HttpGet("{id}")]
        // public ActionResult<AppUser> GetUserDetails(int id){
        //     // var user=_context.Users.Find(id);
        //     // return user;
        //     return _context.Users.Find(id);
        // }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<AppUser>>> GetAsyncUsers(){
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task <ActionResult<AppUser>> GetAsyncUserDetails(int id){
           return await _context.Users.FindAsync(id);
        }
    }
}