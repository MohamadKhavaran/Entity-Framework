using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Services;
using DataLayer.Repository;

namespace DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {

        private MarketDBEntities _context = new MarketDBEntities();
        private IPersonRepository _personrepository;
        public IPersonRepository PersonRepository
        {
            get
            {
                if (_personrepository == null)
                {
                    _personrepository = new PersonRepository(_context);
                }
                return _personrepository;
            }
        }

        public void Save() 
        {
            _context.SaveChanges(); 
        }
        public void Dispose()
        {
        }
    }
}
