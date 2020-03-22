using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreASP.Entity;
using CoreASP.Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoreASP.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        IAuthenticateService _authenticateService;
        public AuthenticationController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }
        [HttpPost]
        public IActionResult Post([FromBody]UserEntity model)
        {
            var user = _authenticateService.Authenticate(model.UserName, model.Password);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            return Ok(user);
        }
    }
}