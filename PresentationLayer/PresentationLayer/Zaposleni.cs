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
    public partial class Zaposleni : Form
    {
        public BusinessEmployee employeeBusiness;
        public Zaposleni()
        {
            InitializeComponent();
            employeeBusiness = new BusinessEmployee();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            listBoxEmployees.Items.Clear();
            List<Employee> employees = employeeBusiness.GetEmployees();
            employees.ForEach(s => listBoxEmployees.Items.Add(s.ToString()));

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Name = textBoxName.Text;
                employee.Surname = textBoxSurname.Text;
                employee.Salary = Convert.ToDecimal(textBoxSalary.Text);

                if (employeeBusiness.InsertEmployee(employee))
                {
                    MessageBox.Show("Uspesan unos!");

                    FillList();

                }
                else
                {
                    MessageBox.Show("Greska u unosu!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Pogresan format unosa");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxEmployees.Items.Clear();

                var min = Convert.ToDecimal(textBoxMinValue.Text);
                var max = Convert.ToDecimal(textBoxMaxValue.Text);
                List<Employee> employees = employeeBusiness.GetEmployeesBetween(min, max);

                employees.ForEach(s => listBoxEmployees.Items.Add(s.ToString()));

                if(employees.Count < 1)
                {
                    MessageBox.Show("Nema zaposlenih sa platom u tom opsegu!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Pogresan unos!");
                FillList();
            }

        }
    }
}
