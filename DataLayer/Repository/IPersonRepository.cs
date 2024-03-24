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
        void insert(Person person);
    }
}
