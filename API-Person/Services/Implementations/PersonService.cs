using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Person.Model;
using API_Person.Model.Context;

namespace API_Person.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private MySqlContext _context;

        public PersonService(MySqlContext context)
        {
            _context = context;
        }


        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));

            try
            {
                if (result != null) _context.Persons.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(prop=>prop.Id.Equals(id));
        }

        public List<Person> FinidAll()
        {
            return _context.Persons.ToList();
        }

        public Person Update(Person person)
        {
            if (!Exist(person.Id))
            {
                return new Person();
            }

            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(person.Id));

            try
            {
                _context.Entry(result).CurrentValues.SetValues(person.Id);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        private bool Exist(long? id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
