using System.Collections;
using ScottPlot;
using ScottPlot.Plottables;
using ScottPlot.TickGenerators;

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
            formsPlot1_Load(sender, e);
        }

        private void incomeBox_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(incomeBox.Text, out income))
            {
                income = float.Parse(incomeBox.Text);
                remainingMoney = income - totalExpenses;
                remainingMoneyBox.Text = remainingMoney.ToString();
                formsPlot1_Load(sender, e);
            }
            else if (incomeBox.Text == "")
            {
                return;
            }
            else
            {
                MessageBox.Show("Please enter number for income");
            }
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
            formsPlot1_Load(sender, e);
        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Refresh();

            formsPlot1.Plot.Add.Bar(position: 1, value: income);
            formsPlot1.Plot.Add.Bar(position: 2, value: totalExpenses);
            formsPlot1.Plot.Add.Bar(position: 3, value: remainingMoney);

            Tick[] ticks =
            {
                new(1, "Income"),
                new(2, "Total Expenses"),
                new(3, "Remaining Money"),
            };

            formsPlot1.Plot.Axes.Bottom.TickGenerator = new NumericManual(ticks);
            formsPlot1.Plot.Axes.Bottom.MajorTickStyle.Length = 0;

            // tell the plot to autoscale with no padding beneath the bars
            formsPlot1.Plot.Axes.Margins(bottom: 0);

            formsPlot1.Refresh();
        }
    }
}
