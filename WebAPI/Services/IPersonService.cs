using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> GetPeople();
    }
}