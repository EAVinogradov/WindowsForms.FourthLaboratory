using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAVinogradov.CSWindowsForms.FourthLaboratory.SecondExample
{
    public partial class EditPersonForm : Form
    {
        Person p;
        public EditPersonForm(Person personal)
        {
            InitializeComponent();
            this.p = p;
            this.FirstName = p.FirstName; 
            this.LastName = p.LastName; 
            this.Age = p.Age;

        }
        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }

        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }

        public int Age
        {
            get { return (int)ageNumericUpDown.Value; }
            set { ageNumericUpDown.Value = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.FirstName = this.FirstName; 
            p.LastName = this.LastName; 
            p.Age = this.Age;
            MessageBox.Show("Сотрудник: " + p.ToString());
        }
    }
}
