using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.models;

namespace WinFormsApp1
{
    public partial class form2 : Form
    {
        Product Product { get; set; }
        public form2(Product product)
        {
            InitializeComponent();
            this.Product = product;
            getdata();
        }

        public void getdata()
        {
            productBindingSource.DataSource = this.Product;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = productBindingSource.Current as Product;

            var list = new[] { textBox4, textBox2, textBox3 };

            if (list.Any(x => string.IsNullOrEmpty(x.Text)))
            {
                MessageBox.Show("Please provide the values");
                return;
            }


            //if(string.IsNullOrEmpty(textBox1.Text))
            //{
            //    MessageBox.Show("Please provide the values");
            //    return;
            //}

            //if(string.IsNullOrEmpty(textBox2.Text))
            //{
            //    MessageBox.Show("Please provide the values");
            //    return;
            //}
            //if(string.IsNullOrEmpty(textBox3.Text))
            //{
            //    MessageBox.Show("Please provide the values");
            //    return;
            //}


            try
            {
                if (item.ProductId == 0)
                {
                    Form1.db.Add(item);
                    Form1.db.SaveChanges();
                    MessageBox.Show("Success");

                    this.Close();
                }
                else
                {
                    Form1.db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    Form1.db.SaveChanges();
                    MessageBox.Show("Success");

                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Save to failed");
            }

        }
    }
}
