using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson55_Conditional_Null_Operator_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person() { FirstName = "Taras ", MiddleName = "Grygorovych ", SecondName = "Shevchenko" },
                new Person() { FirstName = "Ivan", MiddleName = null, SecondName = " Franko " },
                new Person() { FirstName = "Lesya ", MiddleName = " ", SecondName = "Ukrainka" },
                new Person() { FirstName = "uknown", Contacts = new Contacts() {PhoneNumber = "077777777" } }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var persons = GetPersons();
            foreach (var person in persons)
            {
                listBox1.Items.Add($"{person.GetFullName()} | {person.GetPhoneNumber()}");

            }
        }
    }
}
