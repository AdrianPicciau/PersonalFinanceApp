using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalFinanceApp
{
    public partial class Dashboard : Form
    {
        public float income = 0;
        public float totalExpenses = 0;
        public float remainingMoney = 0;

        public Dashboard()
        {
            InitializeComponent();
            
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void incomeBox_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(incomeBox.Text, out income))
            {
                income = float.Parse(incomeBox.Text);
                remainingMoney = income - totalExpenses;
                remainingMoneyBox.Text = remainingMoney.ToString();
            }
            else if(incomeBox.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Please enter number for income");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (!dataGridView1.Columns.Contains("Expenses"))
                return;

            float total = 0f;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Expenses"].Value != null)
                {
                    float.TryParse(row.Cells["Expenses"].Value.ToString(), out float value);
                    total += value;
                }
            }

            totalExpenses = total;

            remainingMoney = income - totalExpenses;
            remainingMoneyBox.Text = remainingMoney.ToString();
        }

        private void remainingMoneyBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
