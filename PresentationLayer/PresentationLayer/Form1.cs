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
        private readonly EmployeeBusiness employeeBusiness;
        public Form1()
        {
            this.employeeBusiness = new EmployeeBusiness();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Employee> list = this.employeeBusiness.GetEmployees();

            listBox1.Items.Clear();

            foreach (Employee e in list)
            {
                listBox1.Items.Add(e.Id + ". " + e.Name + "(" + e.Surname + ") - " +
                    e.Salary);
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Employee e = new Employee();
            e.Name = textBoxName.Text;
            e.Surname = textBoxSurname.Text;
            e.Salary = Convert.ToDecimal(textBoxSalary.Text);

            if (this.employeeBusiness.InsertEmployee(e))
            {
                RefreshData();
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxSalary = "";
            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }
    }
}
