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
    public class RegisterController : ApiController
    {
        // POST api/<controller>
        [HttpPost]
        public async Task<HttpResponseMessage> Get([FromBody] MobileLogin login)
        {

            AccountController ac = new AccountController();
            MobileLogin ml = new MobileLogin();
            
            try
            {
                ml = await ac.Register(login.UserName, login.Password);

                if(ml.success)
                {
                    string userTokerPreFix = "user_token=";

                    return Request.CreateResponse(HttpStatusCode.OK, userTokerPreFix + ml.UserId);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.OK, ml.errorMessage);
                }
                
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "An error has occured.");
            }

        }
    }
}