using System;
using System.Collections.Generic;
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
        //MarketDBEntities _context;
        //IPersonRepository _repository;
        UnitOfWork context = new UnitOfWork(); 
        public Form1()
        {
            //_context = new MarketDBEntities();
            //_repository = new PersonRepository(_context);
            InitializeComponent();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                FirstName = "مینا",
                LastName = "حسینی"
            };
            context.PersonRepository.Insert(person);
            context.Save();
        }

        private void UpdatePerson_btn_Click(object sender, EventArgs e)
        {
            var person = context.PersonRepository.GetById(1);
            person.FirstName = "آیدا";
            context.PersonRepository.Update(person);
            context.Save();
        }

        private void DeletePerson_btn_Click(object sender, EventArgs e)
        {
            context.PersonRepository.DeleteById(1);
            context.Save();
        }

        private void DeletePerson_btn2_Click(object sender, EventArgs e)
        {
            var person = context.PersonRepository.GetById(2);
            context.PersonRepository.Delete(person);
            context.Save();
        }

        private void DisplayPerosn_btn_Click(object sender, EventArgs e)
        {
            var person = context.PersonRepository.GetById(3);
            MessageBox.Show(person.FirstName + " " + person.LastName); 
        }
    }
}
