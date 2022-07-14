using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiUsingDB.Models;

namespace WebApiUsingDB.Controllers
{
    
    public class NewApiController : ApiController
    {
        mashkoordbEntities db = new mashkoordbEntities();
        //non parameteerised action method
        [System.Web.Http.HttpGet]
        public IHttpActionResult Action()
        {
            List<Student> obj = db.Students.ToList();
            return Ok(obj);
        }

        //parameterised action method
        [System.Web.Http.HttpGet]
        public IHttpActionResult Action(int id)
        {
            var obj = db.Students.Where(model => model.StdId == id).FirstOrDefault();
            return Ok(obj);
        }

    }
}
