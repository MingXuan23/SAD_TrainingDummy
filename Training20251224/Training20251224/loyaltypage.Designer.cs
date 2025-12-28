namespace Training20251224
{
    partial class loyaltypage
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
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            membershipStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            totalSpendingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button8 = new Button();
            label10 = new Label();
            dataGridView2 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            loyaltyProgramBindingSource = new BindingSource(components);
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loyaltyProgramBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 88);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 1;
            label2.Text = "Search by name, ID, or email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(856, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { customerIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, membershipStatusDataGridViewTextBoxColumn, Column1, totalSpendingDataGridViewTextBoxColumn });
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.Location = new Point(18, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(856, 412);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.Sorted += dataGridView1_Sorted;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membershipStatusDataGridViewTextBoxColumn
            // 
            membershipStatusDataGridViewTextBoxColumn.DataPropertyName = "MembershipStatus";
            membershipStatusDataGridViewTextBoxColumn.HeaderText = "Membership Status";
            membershipStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            membershipStatusDataGridViewTextBoxColumn.Name = "membershipStatusDataGridViewTextBoxColumn";
            membershipStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Loyalty Points";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // totalSpendingDataGridViewTextBoxColumn
            // 
            totalSpendingDataGridViewTextBoxColumn.DataPropertyName = "TotalSpending";
            totalSpendingDataGridViewTextBoxColumn.HeaderText = "Total Spending";
            totalSpendingDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalSpendingDataGridViewTextBoxColumn.Name = "totalSpendingDataGridViewTextBoxColumn";
            totalSpendingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(models.Customer);
            // 
            // button2
            // 
            button2.Location = new Point(265, 582);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(509, 580);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 586);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(895, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 541);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(3, 327);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 211);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button8
            // 
            button8.Location = new Point(143, 179);
            button8.Name = "button8";
            button8.Size = new Size(198, 29);
            button8.TabIndex = 2;
            button8.Text = "Confirm Update";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 184);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 1;
            label10.Text = "label10";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Column4, Column5 });
            dataGridView2.Location = new Point(6, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(393, 141);
            dataGridView2.TabIndex = 0;
            // 
            // Column2
            // 
            Column2.HeaderText = "Order date";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Amount Spent";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Points Earned";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Bonus Points";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // button7
            // 
            button7.Location = new Point(216, 273);
            button7.Name = "button7";
            button7.Size = new Size(183, 29);
            button7.TabIndex = 3;
            button7.Text = "Redeem Rewards";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(14, 273);
            button6.Name = "button6";
            button6.Size = new Size(183, 29);
            button6.TabIndex = 3;
            button6.Text = "Recalculate Points";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(216, 238);
            button5.Name = "button5";
            button5.Size = new Size(183, 29);
            button5.TabIndex = 3;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(14, 238);
            button4.Name = "button4";
            button4.Size = new Size(183, 29);
            button4.TabIndex = 3;
            button4.Text = "Save Changes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DataBindings.Add(new Binding("Value", loyaltyProgramBindingSource, "Points", true));
            numericUpDown1.Location = new Point(168, 195);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(231, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // loyaltyProgramBindingSource
            // 
            loyaltyProgramBindingSource.DataSource = typeof(models.LoyaltyProgram);
            // 
            // textBox6
            // 
            textBox6.Location = new Point(168, 158);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(231, 27);
            textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(168, 125);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(231, 27);
            textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 92);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(231, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(168, 59);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(231, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 26);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 199);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 0;
            label9.Text = "Loyalty Points:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 156);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 0;
            label8.Text = "Membership Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 123);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 0;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 93);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 0;
            label6.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 64);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 0;
            label5.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 29);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 0;
            label4.Text = "Customer ID:";
            // 
            // loyaltypage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 619);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "loyaltypage";
            Text = "Belle Croissant Lyonnais - Loyalty Management";
            Load += loyaltypage_Load;
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loyaltyProgramBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn membershipStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn totalSpendingDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private Button button2;
        private Button button3;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private NumericUpDown numericUpDown1;
        private BindingSource loyaltyProgramBindingSource;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button8;
        private Label label10;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}