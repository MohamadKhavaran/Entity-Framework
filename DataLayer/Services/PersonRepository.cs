using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Repository;
using System.Data.Entity;
namespace DataLayer.Services
{
    public class PersonRepository : IPersonRepository
    {
        MarketDBEntities _context;
        public PersonRepository(MarketDBEntities Context) 
        {
            _context = Context;
        }

        public void Insert(Person person)
        {
            _context.People.Add(person);
        }

        public Person GetById(int Id)
        {
            return _context.People.Find(Id);
        }

        public void Update(Person person)
        {
            // Update Perosn
            _context.Entry(person).State = EntityState.Modified;
        }

        public void Delete(Person person)
        {
            _context.Entry(person).State = EntityState.Deleted;
        }
        public void DeleteById(int Id)
        {
            var person = GetById(Id);
            Delete(person);
        }
    }
}
