using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQTut
{
    public class Student
    {
        public int StudentId { get; set; }
        //First Name
        public string FirstName { get; set; }
        //Last name
        public string LastName { get; set; }        
        //phone
        public string PhoneNumber { get; set; }
        //email
        public string Email {get; set; }
        //role
        public string Role { get; set; }

        public override string ToString()
        {
            string output = $"{this.FirstName} {this.LastName}";
            return output;
        }
    }
}