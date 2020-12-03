using BusinessLayer;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentatioLayer1
{
    public partial class Form1 : Form
    {
        public EmployeeBusiness employeeBusiness;

        public Form1()
        {
      
                this.employeeBusiness = new EmployeeBusiness();
            
           
            InitializeComponent();
        }
        public void Fill()
        {
            listBoxEmploye.Items.Clear();
            List<Employee> employees = new List<Employee>();

            foreach (Employee e in employees)
            {
                listBoxEmploye.Items.Add(e.Id + "" + e.Name + "" + e.Surname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Name = textBoxnamme.Text;
            em.Surname = textBox1.Text;
            em.Salary = Convert.ToDecimal(textBox2.Text);

            if (this.employeeBusiness.InsertE(em))
            {
                Fill();
                Console.WriteLine("Uspesan unos");

            }
            else
            {
                Console.WriteLine("Neusan unos");

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
