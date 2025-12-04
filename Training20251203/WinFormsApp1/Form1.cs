using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Threading.Tasks;
using WinFormsApp1.models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Product> list = new List<Product>();
        public static ProductDatabaseContext db = new ProductDatabaseContext();

        public Form1()
        {
            InitializeComponent();
        }

        public async void initcontrol()
        {
            await Task.Delay(1000);
            list = db.Products.Include(x => x.ProductIngredients).ToList();

            var current = 0;
            var n = 1;
            //10N * N
            var items = new List<int>();
            while (current < list.Count)
            {
                current = (int)Math.Pow(10, n) * n;
                items.Add(current);
                n++;
            }

            comboBox1.Enabled = false;
            comboBox1.Items.Clear();
            foreach (var i in items)
            {
                comboBox1.Items.Add(i);

            }

            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = true;


            loaddata();

        }

        public async void loaddata()
        {

            dataGridView1.DataSource = null;

            var key = textBox1.Text.ToLower();

            //var temp = list.Where(x => x.ProductName.ToLower().Contains(key) ||
            //x.Category.ToLower().Contains(key) || x.Sku.ToLower().Contains(key)).ToList();



            var temp = list.Where(x => string.Join("|", x.Sku, x.Category, x.ProductName).ToLower().Contains(key)).ToList();


            if (comboBox1.SelectedIndex >= 0)
            {
                var topcount = int.Parse(comboBox1.SelectedItem.ToString());
                temp = temp.Take(topcount).ToList();


            }


            dataGridView1.DataSource = temp;
            //dataGridView1.DataSource = null;
            //dataGridView1.Rows.Clear();
            //foreach (var i in temp)
            //{

            //    var margin = i.RetailPrice - i.ProductionCost;
            //    dataGridView1.Rows.Add(i.Sku, i.ProductName, i.Category, i.RetailPrice.ToString("0.00"),
            //        i.ProductionCost.ToString("0.00"), margin.ToString("0.00"));

            //   // dataGridView1.Rows[dataGridView1.RowCount - 1].Tag = i;

            //    dataGridView1.Rows[^1].Tag = i;
            //}




        }



        private void Form1_Load(object sender, EventArgs e)
        {
            initcontrol();

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {

                    var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;
                    if (item == null) return;
                    e.Value = item.RetailPrice - item.ProductionCost;
                }
                else if (e.ColumnIndex == 7)
                {
                    var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;
                    if (item == null) return;

                    e.Value = string.Join(", ", item.ProductIngredients.Select(x => x.IngredientName).ToArray());

                }
                else if (e.ColumnIndex == 10)
                {
                    e.Value = "edit";
                }
                else if (e.ColumnIndex == 11)
                {
                    e.Value = "delete";

                }
            }
            catch (Exception)
            {


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new form2(new Product()
            {
                RetailPrice = 0,
                ProductionCost = 0,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                Quantity = 0,
            }).ShowDialog();
            list = db.Products.Include(x => x.ProductIngredients).ToList();

            this.Show();

            loaddata();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox1.Enabled) return;
            loaddata();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {

            var text = textBox1.Text;
            await Task.Delay(300);
            if (text != textBox1.Text) return;


            loaddata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;
                this.Hide();
                new form2(item).ShowDialog();
                this.Show();
                list = db.Products.Include(x => x.ProductIngredients).ToList();

                loaddata();
            }
            else if (e.ColumnIndex == 11)
            {
                var item = dataGridView1.Rows[e.RowIndex].DataBoundItem as Product;

                var ques = MessageBox.Show("Are you confirm to delete this item?", "", MessageBoxButtons.OKCancel);

                if (ques == DialogResult.OK)
                {
                    db.Products.Remove(item);
                    db.SaveChanges();
                    MessageBox.Show("Success");
                    list = db.Products.Include(x => x.ProductIngredients).ToList();

                    loaddata();
                }

            }
        }
    }
}
