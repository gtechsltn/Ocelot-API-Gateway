using ApiGatewayWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGatewayWebApi.Interfaces
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }


}
