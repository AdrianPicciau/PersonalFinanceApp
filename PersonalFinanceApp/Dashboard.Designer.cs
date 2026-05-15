namespace PersonalFinanceApp
{
    partial class Dashboard
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
            label1 = new Label();
            incomeBox = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ExpensesName = new DataGridViewTextBoxColumn();
            Expenses = new DataGridViewTextBoxColumn();
            label3 = new Label();
            remainingMoneyBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(252, 38);
            label1.TabIndex = 0;
            label1.Text = "Income Per Month:";
            // 
            // incomeBox
            // 
            incomeBox.Location = new Point(295, 49);
            incomeBox.Name = "incomeBox";
            incomeBox.Size = new Size(150, 27);
            incomeBox.TabIndex = 1;
            incomeBox.TextChanged += incomeBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 103);
            label2.Name = "label2";
            label2.Size = new Size(275, 38);
            label2.TabIndex = 2;
            label2.Text = "Expenses per Month:";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ExpensesName, Expenses });
            dataGridView1.Location = new Point(25, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(420, 341);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // ExpensesName
            // 
            ExpensesName.HeaderText = "Name";
            ExpensesName.MinimumWidth = 6;
            ExpensesName.Name = "ExpensesName";
            ExpensesName.Width = 125;
            // 
            // Expenses
            // 
            Expenses.HeaderText = "Expenses";
            Expenses.MinimumWidth = 6;
            Expenses.Name = "Expenses";
            Expenses.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(491, 49);
            label3.Name = "label3";
            label3.Size = new Size(333, 32);
            label3.TabIndex = 4;
            label3.Text = "Remaining Money Per Month:";
            // 
            // remainingMoneyBox
            // 
            remainingMoneyBox.Location = new Point(499, 103);
            remainingMoneyBox.Name = "remainingMoneyBox";
            remainingMoneyBox.ReadOnly = true;
            remainingMoneyBox.Size = new Size(201, 27);
            remainingMoneyBox.TabIndex = 5;
            remainingMoneyBox.TextChanged += remainingMoneyBox_TextChanged;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(896, 537);
            Controls.Add(remainingMoneyBox);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(incomeBox);
            Controls.Add(label1);
            ForeColor = SystemColors.WindowFrame;
            Name = "Dashboard";
            Text = "Personal Finance App";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox incomeBox;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ExpensesName;
        private DataGridViewTextBoxColumn Expenses;
        private Label label3;
        private TextBox remainingMoneyBox;
    }
}