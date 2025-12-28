namespace Training20251224
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadcontrol(Control control)
        {
            foreach (Control cc in control.Controls)
            {
                loadcontrol(cc);
            }

            if (control is Button b)
            {
                b.FlatStyle = FlatStyle.Flat;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            //for avoid error in rendering gui in winform;


            label1.Text = this.Text;
            loadcontrol(this);

            button1.BackColor = Color.Red; ;
            panel1.BackColor = Color.Brown;
            this.BackColor = Color.WhiteSmoke;
        }
    }
}
