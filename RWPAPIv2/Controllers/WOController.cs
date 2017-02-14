using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RWPAPIv2.Models.Data;

namespace RWPAPIv2.Controllers
{
    public class WOController : ApiController
    {

        RWPEntities _dbWO = new RWPEntities();
                
        // POST api/<controller>
        [HttpPost]
        public HttpResponseMessage Post(string token, [FromBody] Workout workout)
        {

            var _uname = _dbWO.AspNetUsers.First(u => u.Id == token);

            if(_uname == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid Token.");
            }

            try
            {
                _dbWO.Workouts.Add(workout);
                _dbWO.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Success- " + _uname.UserName);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, "Error creating workout.");
            }
        }


        [HttpGet]
        public IHttpActionResult Get(string token)
        {
            try
            {
                string username = _dbWO.AspNetUsers.FirstOrDefault(i => i.Id == token).UserName;
                var wos = _dbWO.Workouts.Where(u => u.UserName == username);
                return Ok(wos);
            }
            catch (Exception)
            {
                return BadRequest();
            }            
            
        }
    }
}