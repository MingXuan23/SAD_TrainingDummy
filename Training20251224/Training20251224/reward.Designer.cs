namespace Training20251224
{
    partial class reward
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
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 100);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 1;
            label2.Text = "Choose a reward option:";
            // 
            // button2
            // 
            button2.Location = new Point(27, 140);
            button2.Name = "button2";
            button2.Size = new Size(460, 29);
            button2.TabIndex = 2;
            button2.Text = "5€ discount on next purchase";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(27, 186);
            button3.Name = "button3";
            button3.Size = new Size(460, 29);
            button3.TabIndex = 2;
            button3.Text = "10% discount on next purchase";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(27, 221);
            button4.Name = "button4";
            button4.Size = new Size(460, 29);
            button4.TabIndex = 2;
            button4.Text = "Upgrade to next membership tier";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(27, 265);
            button5.Name = "button5";
            button5.Size = new Size(207, 29);
            button5.TabIndex = 2;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // reward
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 357);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Name = "reward";
            Text = "Redeem Rewards";
            Load += reward_Load;
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(button4, 0);
            Controls.SetChildIndex(button5, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}