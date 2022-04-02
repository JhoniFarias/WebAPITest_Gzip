using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime RegisterDate { get; set; }


        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < 10000; i++)
            {
                people.Add(new Person()
                { 
                    Id = i, 
                    Age = i,
                    Name = Guid.NewGuid().ToString(),
                    RegisterDate = DateTime.Now 
                });
            }

            return people;
        }
    }
}