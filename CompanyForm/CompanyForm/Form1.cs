using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyForm
{
    public partial class Form1 : Form
    {
        private readonly Business business; 
        public Form1()
        {
            this.business = new Business();
            InitializeComponent();
        }
        private void FillList()
        {
            
            List<Employee> employees = this.business.GetEmployees();
            foreach (Employee em in employees)
            {
                listBoxEmployees.Items.Add(em.Id + ". " + em.Name + ", " + em.Surname + ", " + em.Salary);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillList();
        }
       

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            List<Employee> employees = this.business.GetEmployees();
            Employee em = new Employee();
           em.Name = textBoxName.Text;
            em.Surname = textBoxSurname.Text;
            em.Salary = Convert.ToDecimal(textBoxSalary.Text);

            bool result = this.business.InsertOneEmployee(em);
            if (result)
            {
                FillList();
                MessageBox.Show("Uspesan unos!");
            }
            else
            {
                MessageBox.Show("Neuspesan unos!");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxEmployees.Items.Clear();
            decimal salary1 = Convert.ToDecimal(textBoxMin.Text);
            decimal salary2 = Convert.ToDecimal(textBoxMax.Text);
            List<Employee> employees = this.business.BetweenSalary(salary1, salary2);
            foreach(Employee em in employees)
            {
                listBoxEmployees.Items.Add(em.Id + ". " + em.Name + ", " + em.Surname + ", " + em.Salary);
            }
        }
    }
}
