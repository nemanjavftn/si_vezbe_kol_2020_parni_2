using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                List<Person> list = new List<Person>();
                EmployeesBusiness eb = new EmployeesBusiness();
                foreach (Person a in list)
                {

                    listBox1.Items.Add(a.ToString());
                }
            }
        }

        private void refreshList()
        {
            listBox1.Items.Clear();
            EmployeesBusiness eb = new EmployeesBusiness();
            List<Person> lista = new List<Person>();
            lista = eb.PersonList();
            foreach (Person p in lista)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Person p = new Person(1, textBoxName.Text, textBoxSurname.Text, Convert.ToDecimal(textBoxSalary.Text));
                EmployeesBusiness eb = new EmployeesBusiness(); 
            if (eb.insertPerson(p) == true) 
                MessageBox.Show("Valid"); 
            else 
                MessageBox.Show("Invalid");
            listBox1.Items.Clear();
            Form1_Load(null, null); 
        }

        }
    }
}