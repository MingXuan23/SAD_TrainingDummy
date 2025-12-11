namespace Training6
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            itemBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            addNewItemToolStripMenuItem = new ToolStripMenuItem();
            orderByPriorityToolStripMenuItem = new ToolStripMenuItem();
            priorityToolStripMenuItem = new ToolStripMenuItem();
            idToolStripMenuItem = new ToolStripMenuItem();
            dateTimeToolStripMenuItem = new ToolStripMenuItem();
            goToFirstToolStripMenuItem = new ToolStripMenuItem();
            firstToolStripMenuItem = new ToolStripMenuItem();
            lastToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            doneDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemNoteBindingSource = new BindingSource(components);
            label7 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemNoteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 91);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 132);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 0;
            label2.Text = "Priority";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 182);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 0;
            label3.Text = "DateTime";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", itemBindingSource, "Name", true));
            textBox1.Location = new Point(183, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 27);
            textBox1.TabIndex = 1;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(models.Item);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addNewItemToolStripMenuItem, orderByPriorityToolStripMenuItem, goToFirstToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(554, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // addNewItemToolStripMenuItem
            // 
            addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            addNewItemToolStripMenuItem.Size = new Size(119, 24);
            addNewItemToolStripMenuItem.Text = "Add New Item";
            // 
            // orderByPriorityToolStripMenuItem
            // 
            orderByPriorityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { priorityToolStripMenuItem, idToolStripMenuItem, dateTimeToolStripMenuItem });
            orderByPriorityToolStripMenuItem.Name = "orderByPriorityToolStripMenuItem";
            orderByPriorityToolStripMenuItem.Size = new Size(81, 24);
            orderByPriorityToolStripMenuItem.Text = "Order by";
            // 
            // priorityToolStripMenuItem
            // 
            priorityToolStripMenuItem.Name = "priorityToolStripMenuItem";
            priorityToolStripMenuItem.Size = new Size(161, 26);
            priorityToolStripMenuItem.Text = "Priority";
            // 
            // idToolStripMenuItem
            // 
            idToolStripMenuItem.Name = "idToolStripMenuItem";
            idToolStripMenuItem.Size = new Size(161, 26);
            idToolStripMenuItem.Text = "Id";
            // 
            // dateTimeToolStripMenuItem
            // 
            dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            dateTimeToolStripMenuItem.Size = new Size(161, 26);
            dateTimeToolStripMenuItem.Text = "Date Time";
            // 
            // goToFirstToolStripMenuItem
            // 
            goToFirstToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { firstToolStripMenuItem, lastToolStripMenuItem });
            goToFirstToolStripMenuItem.Name = "goToFirstToolStripMenuItem";
            goToFirstToolStripMenuItem.Size = new Size(62, 24);
            goToFirstToolStripMenuItem.Text = "Go To";
            // 
            // firstToolStripMenuItem
            // 
            firstToolStripMenuItem.Name = "firstToolStripMenuItem";
            firstToolStripMenuItem.Size = new Size(119, 26);
            firstToolStripMenuItem.Text = "First";
            // 
            // lastToolStripMenuItem
            // 
            lastToolStripMenuItem.Name = "lastToolStripMenuItem";
            lastToolStripMenuItem.Size = new Size(119, 26);
            lastToolStripMenuItem.Text = "Last";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(76, 24);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DataBindings.Add(new Binding("Value", itemBindingSource, "Priority", true));
            numericUpDown1.Location = new Point(183, 135);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(297, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", itemBindingSource, "DateTime", true));
            dateTimePicker1.Location = new Point(183, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(297, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 226);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 0;
            label4.Text = "Note Count: ";
            // 
            // button1
            // 
            button1.Location = new Point(30, 478);
            button1.Name = "button1";
            button1.Size = new Size(147, 35);
            button1.TabIndex = 5;
            button1.Text = "Previous";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(336, 475);
            button2.Name = "button2";
            button2.Size = new Size(147, 35);
            button2.TabIndex = 5;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(197, 483);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(63, 27);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 484);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 58);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 8;
            label6.Text = "User name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 58);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(297, 27);
            textBox2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { doneDataGridViewCheckBoxColumn, nameDataGridViewTextBoxColumn, descDataGridViewTextBoxColumn });
            dataGridView1.DataSource = itemNoteBindingSource;
            dataGridView1.Location = new Point(27, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(453, 121);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowsRemoved += dataGridView1_RowsRemoved;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // doneDataGridViewCheckBoxColumn
            // 
            doneDataGridViewCheckBoxColumn.DataPropertyName = "Done";
            doneDataGridViewCheckBoxColumn.HeaderText = "Done";
            doneDataGridViewCheckBoxColumn.MinimumWidth = 6;
            doneDataGridViewCheckBoxColumn.Name = "doneDataGridViewCheckBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descDataGridViewTextBoxColumn
            // 
            descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            descDataGridViewTextBoxColumn.HeaderText = "Desc";
            descDataGridViewTextBoxColumn.MinimumWidth = 6;
            descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            // 
            // itemNoteBindingSource
            // 
            itemNoteBindingSource.DataSource = typeof(models.ItemNote);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.DataBindings.Add(new Binding("Text", itemBindingSource, "Notecount", true));
            label7.Location = new Point(182, 225);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 10;
            label7.Text = "label7";
            // 
            // button3
            // 
            button3.Location = new Point(27, 399);
            button3.Name = "button3";
            button3.Size = new Size(110, 35);
            button3.TabIndex = 5;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(374, 399);
            button4.Name = "button4";
            button4.Size = new Size(109, 35);
            button4.TabIndex = 5;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(143, 399);
            button5.Name = "button5";
            button5.Size = new Size(117, 35);
            button5.TabIndex = 5;
            button5.Text = "Add Note";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 522);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numericUpDown2);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemNoteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addNewItemToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private ToolStripMenuItem orderByPriorityToolStripMenuItem;
        private ToolStripMenuItem goToFirstToolStripMenuItem;
        private DataGridViewCheckBoxColumn doneDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private BindingSource itemNoteBindingSource;
        private ToolStripMenuItem priorityToolStripMenuItem;
        private ToolStripMenuItem idToolStripMenuItem;
        private ToolStripMenuItem dateTimeToolStripMenuItem;
        private ToolStripMenuItem firstToolStripMenuItem;
        private ToolStripMenuItem lastToolStripMenuItem;
        private BindingSource itemBindingSource;
        private Label label7;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}