using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Training20251224.models;

namespace Training20251224
{
    public partial class loyaltypage : Form1
    {
        List<Customer> list = new List<Customer>();

        int index = 0, max = 0;

        Dictionary<int, LoyaltyProgram> loyalty = new Dictionary<int, LoyaltyProgram>();
        public loyaltypage()
        {
            InitializeComponent();

        }

        private void loyaltypage_Load(object sender, EventArgs e)
        {
            getdata();
        }

        public void getdata()
        {
            list = helper.db.Customers.ToList();
            loadtable();
        }

        public async void loadtable()
        {
            dataGridView1.Enabled = false;
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            loyalty = helper.db.LoyaltyPrograms.ToDictionary(x => x.CustomerId, x => x);

            helper.db.ChangeTracker.Entries().ToList().ForEach(x => x.State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);


            groupBox1.Hide();
            var key = textBox1.Text;
            var temp = list.Where(x => string.Join("|", x.Email, x.CustomerId, $"{x.FirstName} {x.LastName}").ToLower().Contains(key.ToLower())).OrderByDescending(x => x.CustomerId).ToList();
            max = (temp.Count + 9) / 10;
            index = 0;


            foreach (var t in temp)
            {
                dataGridView1.Rows.Add(t.CustomerId, t.FirstName, t.LastName, t.Email, loyalty[t.CustomerId].MembershipTier, loyalty[t.CustomerId].Points, t.TotalSpending);
                dataGridView1.Rows[^1].Tag = t;
            }


            dataGridView1.ClearSelection();

            loadpage();

            dataGridView1.Enabled = true;

        }

        public void loadpage()
        {
            var first = index * 10;
            var last = first + 10;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = row.Index >= first && row.Index < last;
            }

            label3.Text = $"Page {index + (max > 0 ? 1 : 0)} of {max}";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            await Task.Delay(300);
            if (text != textBox1.Text)
                return;

            loadtable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--;
            index = Math.Max(0, Math.Min(max - 1, index));
            loadpage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index++;
            index = Math.Max(0, Math.Min(max - 1, index));
            loadpage();
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            index = 0;
            loadpage();
        }

        int selectedcount = 0;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                if (!dataGridView1.Enabled) return;

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var item = dataGridView1.SelectedRows[0].Tag as Customer;
                    if (item == null) return;
                    textBox2.Text = item.CustomerId.ToString(); ;
                    textBox3.Text = item.FirstName;
                    textBox4.Text = item.LastName;
                    textBox5.Text = item.Email;

                    var ly = loyalty[item.CustomerId];
                    loyaltyProgramBindingSource.DataSource = new LoyaltyProgram();
                    loyaltyProgramBindingSource.DataSource = ly;


                    textBox6.Text = ly.MembershipTier;
                    numericUpDown1.Value = ly.Points;

                    groupBox1.Show();
                    groupBox2.Hide();

                }
                else
                {
                    loadtable();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var item = loyaltyProgramBindingSource.Current as LoyaltyProgram;

                helper.db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                helper.db.SaveChanges();

                MessageBox.Show("Success Update points");
                dataGridView1.ClearSelection();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro e");
            }
        }

        int point = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            var item = dataGridView1.SelectedRows[0].Tag as Customer;
            if (item == null) return;


            var ly = loyaltyProgramBindingSource.Current as LoyaltyProgram;
            point = 0;
            //eager loading
            //var customers = helper.db.Customers.Include(x => x.Orders).ToList();

            //explicit loading
            helper.db.Entry(item).Collection(x => x.Orders).Load();

            groupBox2.Show();
            dataGridView2.Rows.Clear();

            foreach (var o in item.Orders)
            {
                int amount = (int)(o.TotalAmount - o.DiscountAmount) / 10;

                var level = ly.MembershipTier switch
                {
                    "Silver" => 12,
                    "Gold" => 15,
                    _ => 10
                };

                var p = amount * level;

                var bonus = (item.JoinDate?.Month, item.JoinDate?.Day) == (o.OrderDate.Month, o.OrderDate.Day) ? 25 : 0;
                bonus += (o.PromotionId != null) ? 5 : 0;

                dataGridView2.Rows.Add(o.OrderDate, o.TotalAmount - o.DiscountAmount, p, bonus);

                point += p + bonus;
            }

            label10.Text = $"Total Points: {point}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                var item = loyaltyProgramBindingSource.Current as LoyaltyProgram;

                item.Points = point;
                helper.db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                helper.db.SaveChanges();

                MessageBox.Show("Success Update points");
                dataGridView1.ClearSelection();
            }
            catch (Exception)
            {


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var item = loyaltyProgramBindingSource.Current as LoyaltyProgram;
            new reward(item.MembershipTier != "Gold").ShowDialog();

            if (reward.option == 1)
            {
                var promotion = new Promotion()
                {
                    PromotionName = $"5€ discount on next purchase for Customer {item.CustomerId}",
                    DiscountType = "FixedAmount",
                    DiscountValue = 5,
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(30),
                    ApplicableProducts = string.Join(",", helper.db.Products.Select(x => x.ProductId)),
                    Priority = 99,
                    QuantityBasedRules = JsonSerializer.Serialize(new { item.CustomerId })
                };

                item.Points -= 1000;

                helper.db.Add(promotion);
                helper.db.SaveChanges();

                MessageBox.Show("Success");
                loadtable();
            }
            else if (reward.option == 2)
            {
                var promotion = new Promotion()
                {
                    PromotionName = $"10% discount on next purchase for Customer {item.CustomerId}",
                    DiscountType = "Percentage",
                    DiscountValue = 10,
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(30),
                    ApplicableProducts = string.Join(",", helper.db.Products.Select(x => x.ProductId)),
                    Priority = 99,
                    QuantityBasedRules = JsonSerializer.Serialize(new { item.CustomerId })
                };

                item.Points -= 1000;

                helper.db.Add(promotion);
                helper.db.SaveChanges();

                MessageBox.Show("Success");
                loadtable();
            }
            else if (reward.option == 3)
            {
                item.Points -= 1000;

                item.MembershipTier = item.MembershipTier switch
                {
                    "Basic" => "Silver",
                    "Silver" => "Gold",
                    _ => item.MembershipTier

                };

                helper.db.SaveChanges();

                MessageBox.Show("Success");
                loadtable();

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button7.Visible = numericUpDown1.Value >= 1000;
        }
    }
}
