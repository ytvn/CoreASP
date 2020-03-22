using CoreASP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreASP.Interface.Service
{
    public interface IAuthenticateService
    {
        UserEntity Authenticate(string username, string password);
    }
}
