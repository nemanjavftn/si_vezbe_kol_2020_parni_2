﻿using BusinessLayer;
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
        private EmployeeBusiness employeeBusiness;
        public Form1()
        {
            InitializeComponent();
            this.employeeBusiness =new  EmployeeBusiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
