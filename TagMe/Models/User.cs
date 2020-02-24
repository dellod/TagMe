using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagMe.Models
{
    public class User
    {
        //private var uuid; HAVE TO MAKE THIS BIG INTEGER, 128 bits
        private string username;
        private string firstName;
        private string lastName;
   
        /** CONSTRUCTORS **/
        public User(string u, string f, string l)
        {
            username = u;
            firstName = f;
            lastName = l;
        }

        /** GETTERS AND SETTERS **/
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /** METHODS **/
        public bool queryUser(string user)
        {
            // NEED TO GET FROM DATABASE
        }
    }
}
