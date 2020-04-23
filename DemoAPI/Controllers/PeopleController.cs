using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers {
    /// <summary>
    /// This where I give you ~~~~ bla bla
    /// </summary>
    public class PeopleController : ApiController {

        List<Person> people = new List<Person>();



        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <param name="userId">The unique identifier or this person.</param>
        /// <param name="age">We wnat to know how old they are.</param>
        /// <returns>A list of first names.. duh</returns>
        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(string userId, int age) {
            List<string> output = new List<string>();
            foreach(var p in people) {
                output.Add(p.FirstName);
            }
            return output;
        }


        public PeopleController() {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm", Id = 2 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Baggins", Id = 3 });
            people.Add(new Person { FirstName = "Yoo", LastName = "KwangSoo", Id = 14 });
        }



        // GET: api/People
        public List<Person> Get() {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id) {
            return people.Where(x => x.Id == id).FirstOrDefault(); ;
        }

        // POST: api/People
        public void Post(Person val) {
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE: api/People/5
        public void Delete(int id) {
            
        }
    }
}
