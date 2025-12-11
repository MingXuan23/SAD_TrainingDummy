using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Caching.Hybrid;
using Training6.models;

namespace Training6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
            this.Text = "Login Form - Alice";


            textBox1.Text = "alice.admin@example.com";
            textBox2.Text = "hashedpassword1";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var reader = new StreamReader("D:\\CMX FILE\\utem_degree\\year2sem2\\c#_note\\SAD_TrainingDummy\\Training6\\Training6\\user.txt");
            //var result = reader.ReadToEnd();
            //MessageBox.Show(result);

            var properties = Properties.Settings.Default.Username;
            MessageBox.Show(properties);
        }

        private void button1_Click(object sender, EventArgs e)

        {

            try
            {



                helper.user = helper.db.Users.Include(x => x.Items)
                    .ThenInclude(x => x.ItemNotes)
                    .ToList()
                    .FirstOrDefault(x => x.Email == textBox1.Text && x.Password == textBox2.Text) ?? throw new Exception();
                // LIKE "%case insentisitive%"
                //helper.user = helper.db.Users
                //    .ToList()
                //   .FirstOrDefault(x => x.Email == textBox1.Text && x.Password == textBox2.Text) ?? throw new Exception();

                //var writer = new StreamWriter("D:\\CMX FILE\\utem_degree\\year2sem2\\c#_note\\SAD_TrainingDummy\\Training6\\Training6\\user.txt");

                //writer.Write(helper.user.Name);
                //writer.Close();



                //Properties.Settings.Default["Username"] = "a value";
                //Properties.Settings.Default.Save();



                this.Hide();
                new Form2().ShowDialog();

                this.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Invalid Login");
            }

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
