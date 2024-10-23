using APIGATEWAYSPG.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGATEWAYSPG.Interfaces
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }


}
