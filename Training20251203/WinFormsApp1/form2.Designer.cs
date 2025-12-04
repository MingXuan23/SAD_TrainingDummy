namespace WinFormsApp1
{
    partial class form2
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            productBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            productIngredientBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ingredientNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityRequiredDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitOfMeasureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costPerUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label10 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productIngredientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Product Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 66);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 0;
            label2.Text = "SKU:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 102);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 216);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 0;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 250);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 0;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 287);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 0;
            label6.Text = "Cost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 326);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 0;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 377);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 0;
            label8.Text = "Created At";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 422);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 0;
            label9.Text = "Modified At";
            label9.Click += label8_Click;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", productBindingSource, "ProductId", true));
            textBox1.Location = new Point(176, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 27);
            textBox1.TabIndex = 1;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(models.Product);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", productBindingSource, "Sku", true));
            textBox2.Location = new Point(176, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", productBindingSource, "ProductName", true));
            textBox3.Location = new Point(176, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(344, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", productBindingSource, "Category", true));
            textBox4.Location = new Point(176, 213);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(344, 27);
            textBox4.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DataBindings.Add(new Binding("Value", productBindingSource, "RetailPrice", true));
            numericUpDown1.Location = new Point(178, 250);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(342, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DataBindings.Add(new Binding("Value", productBindingSource, "ProductionCost", true));
            numericUpDown2.Location = new Point(176, 287);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(342, 27);
            numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DataBindings.Add(new Binding("Value", productBindingSource, "Quantity", true));
            numericUpDown3.Location = new Point(176, 326);
            numericUpDown3.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(342, 27);
            numericUpDown3.TabIndex = 2;
            // 
            // productIngredientBindingSource
            // 
            productIngredientBindingSource.DataSource = typeof(models.ProductIngredient);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", productBindingSource, "CreatedDate", true));
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(176, 378);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(344, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.DataBindings.Add(new Binding("Value", productBindingSource, "ModifiedDate", true));
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Location = new Point(174, 417);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(344, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ingredientNameDataGridViewTextBoxColumn, quantityRequiredDataGridViewTextBoxColumn, unitOfMeasureDataGridViewTextBoxColumn, costPerUnitDataGridViewTextBoxColumn, supplierNameDataGridViewTextBoxColumn, notesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productIngredientBindingSource;
            dataGridView1.Location = new Point(582, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(688, 323);
            dataGridView1.TabIndex = 4;
            // 
            // ingredientNameDataGridViewTextBoxColumn
            // 
            ingredientNameDataGridViewTextBoxColumn.DataPropertyName = "IngredientName";
            ingredientNameDataGridViewTextBoxColumn.HeaderText = "IngredientName";
            ingredientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            ingredientNameDataGridViewTextBoxColumn.Name = "ingredientNameDataGridViewTextBoxColumn";
            // 
            // quantityRequiredDataGridViewTextBoxColumn
            // 
            quantityRequiredDataGridViewTextBoxColumn.DataPropertyName = "QuantityRequired";
            quantityRequiredDataGridViewTextBoxColumn.HeaderText = "QuantityRequired";
            quantityRequiredDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityRequiredDataGridViewTextBoxColumn.Name = "quantityRequiredDataGridViewTextBoxColumn";
            // 
            // unitOfMeasureDataGridViewTextBoxColumn
            // 
            unitOfMeasureDataGridViewTextBoxColumn.DataPropertyName = "UnitOfMeasure";
            unitOfMeasureDataGridViewTextBoxColumn.HeaderText = "UnitOfMeasure";
            unitOfMeasureDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitOfMeasureDataGridViewTextBoxColumn.Name = "unitOfMeasureDataGridViewTextBoxColumn";
            // 
            // costPerUnitDataGridViewTextBoxColumn
            // 
            costPerUnitDataGridViewTextBoxColumn.DataPropertyName = "CostPerUnit";
            costPerUnitDataGridViewTextBoxColumn.HeaderText = "CostPerUnit";
            costPerUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            costPerUnitDataGridViewTextBoxColumn.Name = "costPerUnitDataGridViewTextBoxColumn";
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            button1.Location = new Point(76, 488);
            button1.Name = "button1";
            button1.Size = new Size(175, 54);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 488);
            button2.Name = "button2";
            button2.Size = new Size(175, 54);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 138);
            label10.Name = "label10";
            label10.Size = new Size(41, 20);
            label10.TabIndex = 0;
            label10.Text = "Desc";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", productBindingSource, "Description", true));
            textBox5.Location = new Point(174, 138);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(344, 69);
            textBox5.TabIndex = 1;
            // 
            // form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 549);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "form2";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)productIngredientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ingredientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityRequiredDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitOfMeasureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costPerUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private BindingSource productIngredientBindingSource;
        private Button button1;
        private Button button2;
        private Label label10;
        private TextBox textBox5;
        private BindingSource productBindingSource;
    }
}