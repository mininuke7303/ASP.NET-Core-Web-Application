using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers {
    public class PeopleController : ApiController {

        List<Person> people = new List<Person>();

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
