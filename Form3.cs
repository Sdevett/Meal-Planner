namespace Meal_Planner
{
    public partial class Form3 : Form
    {
        List<Recipe> recipeBook = new List<Recipe>();
        Recipe selected;
        Form2 editForm;

        public Form3()
        {
            InitializeComponent();
            editForm = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                selected = (Recipe)listBox1.Items[listBox1.SelectedIndex];
                label2.Text = selected.getName();
                List<string> selectedList = selected.getIngredients();
                label5.Text = string.Join(", ", selectedList);
                panel1.Visible = true;
                selectedList = selected.getDirections();
                textBox1.Text = string.Join("\r\n\r\n", selectedList);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                selected = (Recipe)listBox1.Items[listBox1.SelectedIndex];
                recipeBook.Remove(selected);
                listBox1.DataSource = null;
                listBox1.DataSource = recipeBook;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selected = (Recipe)listBox1.Items[listBox1.SelectedIndex];
            recipeBook = editForm.EditRecipe(recipeBook, listBox1.SelectedIndex);
        }

        public List<Recipe> showRecipes(List<Recipe> recipes)
        {
            recipeBook = recipes;
            listBox1.DataSource = recipeBook;
            this.ShowDialog();
            return recipeBook;
        }
    }
}
