using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class PersonService : IPersonService
    {
        public IEnumerable<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < 10000; i++)
            {
                people.Add(new Person()
                {
                    Id = i,
                    Name = "Jhoni Farias Dos Santos",
                    RegisterDate = DateTime.Now
                });
            }

            return people;
        }
    }
}