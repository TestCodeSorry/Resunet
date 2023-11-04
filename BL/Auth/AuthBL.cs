using System;
using Resunet.DAL.Models;
using Resunet.DAL;

namespace Resunet.BL.Auth
{
    public class AuthBL : IAuthBL
    {
        private readonly IAuthDAL authDal;

        public AuthBL(IAuthDAL authDal)
        {
            this.authDal = authDal;
        }

        public async Task<int> CreateUser(UserModel user)
        {
            return await authDal.CreateUser(user);
        }
    }
}
