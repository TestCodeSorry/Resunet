using Resunet.DAL.Models;
using System;

namespace Resunet.BL.Auth
{
    public interface IAuthBL
    {
        Task<int> CreateUser(UserModel user);
    }
}
