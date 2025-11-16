using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Meal_Planner
{
    public partial class Form4 : Form
    {
        List<Recipe> recipeBook;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            int numDays = Convert.ToInt32(textBox1.Text);
            DateTime endDate = startDate.AddDays(numDays);

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "date";
            dataGridView1.Columns[1].Name = "Breakfast";
            dataGridView1.Columns[2].Name = "Lunch";
            dataGridView1.Columns[3].Name = "Dinner";


            while (startDate != endDate)
            {
                dataGridView1.Rows.Add(startDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                startDate = startDate.AddDays(1);
            }

            dateTimePicker1.Enabled = false;
            textBox1.Enabled = false;
            label1.Text = "Selected a meal to add it to the Meal Planner";
            listBox1.Enabled = true;
            listBox1.Visible = true;
            button3.Enabled = true;
            button3.Visible = true;
            dataGridView1.CurrentCell =
                   dataGridView1.CurrentCell =
                   dataGridView1.Rows[0].Cells[1];
            dataGridView1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dateTimePicker1.Enabled = true;
            textBox1.Enabled = true;
            label1.Text = "Start Date:";
            listBox1.Enabled = false;
            listBox1.Visible = false;
            button3.Enabled = false;
            button3.Visible = false;
            Close();
        }

        public void SelectedMeals(List<Recipe> recipes)
        {
            textBox1.Text = "7";
            recipeBook = recipes;
            listBox1.DataSource = recipeBook;
            this.ShowDialog();
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Recipe recipe = recipeBook[listBox1.SelectedIndex];
            dataGridView1.CurrentCell.Value = recipe;

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int colIndex = dataGridView1.CurrentCell.ColumnIndex + 1;

            if (colIndex > 3)
            {
                rowIndex++;
                colIndex = 1;
            }
            if (rowIndex >= dataGridView1.Rows.Count)
            {
                colIndex = 1;
                rowIndex = 0;
            }

            dataGridView1.CurrentCell =
                dataGridView1.CurrentCell =
                dataGridView1.Rows[rowIndex].Cells[colIndex];

            dataGridView1.Rows[rowIndex].Cells[colIndex].Selected = true;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Date,Breakfast,Lunch,Dinner\n");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                sb.Append(" ");
                for ( int j = 0;  j < row.Cells.Count; j++)
                {
                    sb.Append(row.Cells[j].Value + ",");
                }
                sb.Append('\n');
            }
            string data = sb.ToString();


            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                try
                {
                    File.WriteAllText(filePath, data);
                    MessageBox.Show($"File saved successfully at: {filePath}", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error");
                }
            }

            button2_Click(sender, e);
        }
    }
}
