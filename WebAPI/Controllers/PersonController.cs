using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Filters;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    public class PersonController : ApiController
    {
        private IPersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }

        /// <summary
        //// Utilizado ActionFilterAttribute para comprimir o Json retornado.
        /// </summary>
        /// <returns>IEnumerable<Person></returns>
        [GzipCompressionFilter]
        public IHttpActionResult Get()
        {
            IEnumerable<Person> people = _personService.GetPeople();
            return Ok(people);
        }
    }
}
