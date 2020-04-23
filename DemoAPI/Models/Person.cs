using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models {
    
    
    /// <summary>
    /// 특정인에 대한 정보를 보관
    /// </summary>
    public class Person {


        /// <summary>
        ///  The Unique ID
        /// </summary>
        public int Id { get; set; } = 0;



        /// <summary>
        /// the User's First Name
        /// </summary>
        public string FirstName { get; set; } = "";



        /// <summary>
        /// the User's Last Name
        /// </summary>
        public string LastName { get; set; } = "";

        
    }
}