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

        private void RefreshData()
        {
            List<Employee> employees = this.employeeBusiness.GetAllEmployees();
            listBoxEmployees.Items.Clear();

            foreach(Employee e in employees)
            {
                e.Name = textBox1.Text;
                e.Surname = textBox2.Text;
                e.Salary = Convert.ToDecimal(textBox3.Text);

                if (this.employeeBusiness.InsertEmployees(e))
                {
                    RefreshData();
                }
            }
        }
        private void listBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
