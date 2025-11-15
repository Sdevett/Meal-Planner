using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meal_Planner
{
    public partial class Form2 : Form
    {
        List<Recipe> recipeBook = new List<Recipe>();
        Recipe selected;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox21.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel2.Enabled)
            {
                panel2.Enabled = false;
                panel2.Visible = false;
            }
            panel1.Enabled = true;
            panel1.Visible = true;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panel1.Enabled)
            {
                panel1.Enabled = false;
                panel1.Visible = false;
            }
            panel2.Enabled = true;
            panel2.Visible = true;
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(richTextBox1.Text);
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            panel2.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex >= 0)
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox21.Text.Length !=0)
            {
               DialogResult question = MessageBox.Show
                    (
                    "It seems that you have a recipe " +
                    "that you havent added to the recipe book yet." +
                    " Would you like to add it?"
                    , "Recipe Left Out!!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                    );

                //this is wack
                bool saveRecipe = question == DialogResult.Yes;
                if(saveRecipe)
                {
                    this.button3_Click(sender, e);
                }
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox21.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox21.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox21.Text;
            List<string> ingredients = listBox1.Items.Cast<string>().ToList();
            List<string> directions = listBox2.Items.Cast<string>().ToList();
            Recipe temp = new Recipe(name, ingredients, directions);
            recipeBook.Add(temp);

            textBox21.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox21.Focus();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            selected.setName(textBox21.Text);
            selected.setIngredients(listBox1.Items.Cast<string>().ToList());
            selected.setDirections(listBox2.Items.Cast<string>().ToList());
            Close();
        }

        public List<Recipe> GetInformation(List<Recipe> recipes)
        {
            this.Text = "Add Recipe";
            recipeBook = recipes;
            this.ShowDialog();
            return recipeBook;
        }

        public List<Recipe> EditRecipe(List<Recipe> recipes, int selectedIndex)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button12.Enabled = true;
            button12.Visible = true;
            this.Text = "Edit Recipe";
            recipeBook = recipes;

            selected = recipes[selectedIndex];
            textBox21.Text = selected.getName();

            List<string> selectedData = selected.getIngredients();
            foreach(string item in selectedData)
                listBox1.Items.Add(item);
            selectedData = selected.getDirections();
            foreach(string item in selectedData)
                listBox2.Items.Add(item);

            this.ShowDialog();
            return recipeBook;
        }

    }
}
