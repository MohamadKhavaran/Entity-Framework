using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Repository;
using DataLayer.Services;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            MarketDBEntities context = new MarketDBEntities();
            IPersonRepository repository = new PersonRepository(context);
            Person person = new Person()
            {
                FirstName = "محمد حسین",
                LastName = "خاوران"
            };
            repository.insert(person);
        }
    }
}
