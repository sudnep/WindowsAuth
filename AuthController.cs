using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using url_shorten_api.Helpers;

namespace url_shorten_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ADService _authService;
        public AuthController(ADService authService)
        {
            this._authService = authService;
            
        }
       [Authorize(Roles = "secmail@mufg-is.com")]  
       [HttpGet("{group}", Name = "CheckGroup")]
        public  bool Get(string group)
        {
           //var check =  _authService.CheckGroupMembership(User, group);           
       
            return true;
        }

    }
}s