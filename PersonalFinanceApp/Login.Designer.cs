namespace PersonalFinanceApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UserNameBox = new TextBox();
            PasswordBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 90);
            label1.Name = "label1";
            label1.Size = new Size(493, 51);
            label1.TabIndex = 0;
            label1.Text = "Personal Finance App";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(123, 232);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(123, 288);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // UserNameBox
            // 
            UserNameBox.Location = new Point(238, 236);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(125, 27);
            UserNameBox.TabIndex = 3;
            UserNameBox.TextChanged += UserNameBox_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(238, 292);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(125, 27);
            PasswordBox.TabIndex = 4;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(238, 357);
            button1.Name = "button1";
            button1.Size = new Size(132, 47);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(842, 453);
            Controls.Add(button1);
            Controls.Add(PasswordBox);
            Controls.Add(UserNameBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UserNameBox;
        private TextBox PasswordBox;
        private Button button1;
    }
}
