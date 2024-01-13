using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Resunet.BL.Auth;
using Resunet.DAL;


namespace Resutest.Helpers
{
    public class BaseTest
    {
        protected IAuthDAL authDal = new AuthDAL();
        protected IEncrypt encrypt = new Encrypt();
        protected IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
        protected IAuthBL authBL;

        public BaseTest()
        {
            authBL = new AuthBL(authDal, encrypt, httpContextAccessor);
        }
    }
}
