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
        MarketDBEntities _context;
        IPersonRepository _repository;
        public Form1()
        {
            _context = new MarketDBEntities();
            _repository = new PersonRepository(_context);
            InitializeComponent();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                FirstName = "محمد حسین",
                LastName = "خاوران"
            };
            _repository.Insert(person);
        }

        private void UpdatePerson_btn_Click(object sender, EventArgs e)
        {
            var person = _repository.GetById(1);
            person.FirstName = "آیدا";
            _repository.Update(person);
        }

        private void DeletePerson_btn_Click(object sender, EventArgs e)
        {
            _repository.DeleteById(1);
        }

        private void DeletePerson_btn2_Click(object sender, EventArgs e)
        {
            var person = _repository.GetById(2);
            _repository.Delete(person);
        }

        private void DisplayPerosn_btn_Click(object sender, EventArgs e)
        {
            var person = _repository.GetById(3);
            MessageBox.Show(person.FirstName + " " + person.LastName);
        }
    }
}
