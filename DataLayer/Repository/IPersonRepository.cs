using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
namespace DataLayer.Repository
{
    public interface IPersonRepository
    {
        void Insert(Person person);

        Person GetById(int Id);

        void Update(Person person);

        void Delete(Person person);

        void DeleteById(int Id);
    }
}
