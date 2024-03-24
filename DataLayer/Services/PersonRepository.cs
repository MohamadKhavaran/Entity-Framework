using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Repository;
namespace DataLayer.Services
{
    public class PersonRepository : IPersonRepository
    {
        MarketDBEntities _context;
        public PersonRepository(MarketDBEntities Context)
        {
            _context = Context; 
        }

        private  void Save()
        {
            _context.SaveChanges();
        }
        public void insert(Person person)
        {
            _context.People.Add(person);
            Save();
        }
    }
}
