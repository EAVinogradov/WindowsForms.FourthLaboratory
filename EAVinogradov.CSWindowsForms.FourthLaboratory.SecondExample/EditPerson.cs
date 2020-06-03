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
    public partial class EditPerson : Form
    {
        
        public EditPerson()
        {
            InitializeComponent();
        }
        List<Person> pers = new List<Person>();
        public void button1_Click(object sender, EventArgs e)
        {
            Person personal = new Person();
            EditPersonForm editForm = new EditPersonForm(personal);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            pers.Add(personal);
            listView1.VirtualListSize = pers.Count;
            listView1.Invalidate();
            //ListViewItem newItem = personsListView.Items.Add(editForm.FirstName); 
            //newItem.SubItems.Add(editForm.LastName); 
            //newItem.SubItems.Add(editForm.Age.ToString());

        }

        public void button2_Click(object sender, EventArgs e)
        {
            //if (personsListView.SelectedItems.Count == 0)
                //return;
            
            Person personal = pers[listView1.SelectedIndices[0]];
            //ListViewItem item = personsListView.SelectedItems[0];
            EditPersonForm editForm = new EditPersonForm(personal);
            //editForm.FirstName = item.Text; editForm.LastName = item.SubItems[1].Text;
            //editForm.Age = Convert.ToInt32(item.SubItems[2].Text);
            if (editForm.ShowDialog() != DialogResult.OK)
            {
                listView1.Invalidate();
            }
                //return;
            //item.Text = editForm.FirstName; 
            //item.SubItems[1].Text = editForm.LastName; 
            //item.SubItems[2].Text = editForm.Age.ToString();

        }

        public void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName); 
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName); 
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }

        }

        public void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); foreach (Person item in pers)
            {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
