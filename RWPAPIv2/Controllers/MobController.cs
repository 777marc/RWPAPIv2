using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RWPAPIv2.Models.Data;
using RWPAPIv2.Models;
using System.Threading.Tasks;

namespace RWPAPIv2.Controllers
{
    public class MobController : ApiController
    {

        TokenEntities _db = new TokenEntities();

        // POST api/<controller>
        public async Task<HttpResponseMessage> Get(string username, string pw)
        {

            AccountController ac = new AccountController();
            LoginViewModel lm = new LoginViewModel();

            lm.UserName = username;
            lm.Password = pw;
            lm.RememberMe = false;

            string userToken = "";

            try
            {
                string result = await ac.Login(lm);
                userToken = result;
                return Request.CreateResponse(HttpStatusCode.OK, userToken);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "Unauthorized");
            }

        }


    }
}