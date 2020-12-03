using AccessDataLayer.Models;
using BusinessLayer;
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
            this.workerBusiness = new WorkerBusiness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Worker> result = this.workerBusiness.GetEmployees();
            listBox.Items.Clear();
            foreach (Worker w in worker)
            {
                listBox.Items.Add(w.Name + " , " + w.Surname + " , " + w.Salary);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();
            w.Name = textBoxName.Text;
            w.Surname = textBoxSurname.Text;
            w.Salary = Convert.ToDecimal(textBoxSalary.Text);

            if (this.workerBusiness.Insert(s))
            {
                RefreshData();
                textBoxName.Clear();
                textBoxSurname.Clear();
                textBoxSalary.Clear();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
