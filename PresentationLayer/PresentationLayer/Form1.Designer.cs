
namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Insert = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Do = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 289);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(777, 147);
            this.listBox1.TabIndex = 0;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(103, 177);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(115, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(115, 72);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 3;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(115, 112);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(46, 42);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 6;
            this.Name.Text = "Name";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(46, 75);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(49, 13);
            this.Surname.TabIndex = 7;
            this.Surname.Text = "Surname";
            this.Surname.Click += new System.EventHandler(this.label2_Click);
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(46, 115);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(36, 13);
            this.Salary.TabIndex = 8;
            this.Salary.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Od";
            // 
            // Do
            // 
            this.Do.AutoSize = true;
            this.Do.Location = new System.Drawing.Point(427, 100);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(21, 13);
            this.Do.TabIndex = 10;
            this.Do.Text = "Do";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(505, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(508, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Zaposleni";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Do;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

