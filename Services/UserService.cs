using ApiGatewayWebApi.Interfaces;
using ApiGatewayWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGatewayWebApi.Services
{
    public class UserService : IUserService
    {
        Task<User> IUserService.Authenticate(string username, string password)
        {
            var user = new User();

            try
            {
                // if you want then add user verify also..
                //var userlist = _context.Tbl_Users.Where(s => s.UserId == username && s.Password == password && s.Status == 1).FirstOrDefault();
                if (user != null)
                {
                    user.User_Id = username;
                    user.UserName = username;
                    return Task.FromResult(user);
                }
                else
                    return Task.FromResult<User>(null);
            }
            catch (Exception es)
            {
                return Task.FromResult<User>(null);
            }
        }
    }
}
