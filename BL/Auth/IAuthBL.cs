using System;
using Resunet.DAL.Models;

namespace Resunet.BL.Auth
{
    public interface IAuthBL
    {
        Task<int> CreateUser(UserModel user);
        Task<int> Authenticate(string email, string password, bool rememberMe);
    }
}
