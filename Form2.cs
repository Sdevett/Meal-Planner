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
        bool newItem = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            recipeName.Focus();
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
            newItem = true;
            addIngredientsButton.Enabled = true;
            addIngredientsButton.Visible = true;
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
            newItem = true;
            addDirectionButton.Enabled = true;
            addDirectionButton.Visible = true;
            panel2.Enabled = true;
            panel2.Visible = true;
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ingredientsBox.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!newItem)
                ingredientsBox.Items[ingredientsBox.SelectedIndex] = textBox1.Text;
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
            if (!newItem)
            {
                listBox2.Items[listBox2.SelectedIndex] = richTextBox1.Text;
            }
            panel2.Enabled = false;
            panel2.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ingredientsBox.SelectedIndex >= 0)
                ingredientsBox.Items.RemoveAt(ingredientsBox.SelectedIndex);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (recipeName.Text.Length != 0)
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
                if (saveRecipe)
                {
                    this.button3_Click(sender, e);
                }
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show
                (
                " Any recipes added after you click this button will only " +
                "show up after the application is refreshed." +
                " Are you sure you would like to proceed?", "Attention!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation
                );
            bool proceed = question == DialogResult.Yes;
            if (proceed)
            {
                this.TopMost = true;
                resetButton.Visible = false;
                recipeName.Clear();
                ingredientsBox.Items.Clear();
                listBox2.Items.Clear();
                recipeName.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = recipeName.Text;
            List<string> ingredients = ingredientsBox.Items.Cast<string>().ToList();
            List<string> directions = listBox2.Items.Cast<string>().ToList();
            Recipe temp = new Recipe(name, ingredients, directions);
            recipeBook.Add(temp);

            recipeName.Clear();
            this.ingredientsBox.Items.Clear();
            listBox2.Items.Clear();
            recipeName.Focus();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            selected.setName(recipeName.Text);
            selected.setIngredients(ingredientsBox.Items.Cast<string>().ToList());
            selected.setDirections(listBox2.Items.Cast<string>().ToList());
            ingredientsBox.Items.Clear();
            listBox2.Items.Clear();
            Close();
        }

        public List<Recipe> GetInformation(List<Recipe> recipes)
        {
            this.Text = "Add Recipe";
            recipeBook = recipes;
            this.ShowDialog();
            return recipeBook;
        }

        public List<Recipe> EditRecipe(List<Recipe> recipes, Recipe editRecipe)
        {
            doneAdding.Enabled = false;
            resetButton.Enabled = false;
            addToRecipebook.Enabled = false;
            doneAdding.Visible = false;
            resetButton.Visible = false;
            addToRecipebook.Visible = false;
            finishedEditing.Enabled = true;
            finishedEditing.Visible = true;
            this.Text = "Edit Recipe";
            recipeBook = recipes;

            foreach (Recipe i in recipes)
                if (i == editRecipe)
                    selected = i;

            recipeName.Text = selected.getName();
            List<string> selectedData = selected.getIngredients();
            foreach (string item in selectedData)
                ingredientsBox.Items.Add(item);
            selectedData = selected.getDirections();
            foreach (string item in selectedData)
                listBox2.Items.Add(item);

            this.ShowDialog();
            return recipes;
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                button7_Click(sender, e);
                string temp = listBox2.SelectedItem.ToString();
                richTextBox1.Text = temp;
                newItem = false;
                addDirectionButton.Enabled = false;
                addDirectionButton.Visible = false;

            }

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (ingredientsBox.SelectedIndex != -1)
            {
                button6_Click(sender, e);
                string temp = ingredientsBox.SelectedItem.ToString();
                textBox1.Text = temp;
                newItem = false;
                addIngredientsButton.Enabled = false;
                addIngredientsButton.Visible = false;

            }
        }

        private void ingredientsBox_DragEnter(object sender, DragEventArgs e)
        {
            bool dragInfoIsText = e.Data.GetDataPresent(DataFormats.Text);
            if (dragInfoIsText)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ingredientsBox_DragDrop(object sender, DragEventArgs e)
        {
                string dropInfo = (string)e.Data.GetData(DataFormats.Text);
                if(!String.IsNullOrWhiteSpace(dropInfo))
                {
                    ingredientsBox.Items.Add(dropInfo.Trim());
                }
        }
    }
}
