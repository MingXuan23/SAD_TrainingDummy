using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Training6.models;

namespace Training6
{
    public partial class Form2 : Form
    {
        List<Item> items = new List<Item>();
        int index = 1;

        User user { get; set; }
        public Form2()
        {
            InitializeComponent();

            loaddata();
        }

        public void loaddata()
        {
            textBox2.Text = "Alice";
            items = helper.user.getItem().ToList();
            numericUpDown2.Maximum = items.Count;
            index = 1;
            numericUpDown2.Minimum = index;

            this.Text = "Welcome Alice";
            label5.Text = $" of {items.Count}";
            loaditem();
        }

        public void loaditem()
        {
            items = helper.user.Items.ToList();

            helper.db.ChangeTracker.Entries().ToList()
                .ForEach(x => x.State = EntityState.Unchanged);
            var item = items[index - 1];
            itemBindingSource.DataSource = new Item();
            itemBindingSource.DataSource = item;
            dataGridView1.DataSource = new ObservableCollection<ItemNote>(item.ItemNotes).ToBindingList();

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deleted = helper.db.ChangeTracker.Entries().Count(x => x.State == EntityState.Deleted);
            var added = helper.db.ChangeTracker.Entries().Count(x => x.State == EntityState.Added);
            var modified = helper.db.ChangeTracker.Entries().Count(x => x.State == EntityState.Modified);
            helper.db.SaveChanges();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var item = items[index - 1];
            item.ItemNotes.Add(new ItemNote());
            dataGridView1.DataSource = new ObservableCollection<ItemNote>(item.ItemNotes).ToBindingList();

        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {


        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            var row = e.Row.DataBoundItem as ItemNote;
            helper.db.Remove(row);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            index--;

            index = Math.Max(1, Math.Min(items.Count, index));
            numericUpDown2.Value = index;

            //index--;
            //if (index < 0)
            //{
            //    index = 0;
            //}
            //else if (index > items.Count)
            //{
            //    index = items.Count;
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            index = Math.Max(1, Math.Min(items.Count, index));
            numericUpDown2.Value = index;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            index = (int)numericUpDown2.Value;
            loaditem();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            loaditem();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
