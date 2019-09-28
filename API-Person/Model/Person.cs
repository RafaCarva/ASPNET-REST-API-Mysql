using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Person.Model
{
    public class Person
    {
        //Quando o long não é definido ele atribui 0 automaticamente.
        //o "?" diz para deixar null.
        public long? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
