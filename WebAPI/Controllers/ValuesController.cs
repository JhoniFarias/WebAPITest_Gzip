using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Filters;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        private Person _person;

        public ValuesController()
        {
            _person = new Person();
        }
        
        public IHttpActionResult Get()
        {
            return Ok(_person.GetPeople());
        }
    }
}
