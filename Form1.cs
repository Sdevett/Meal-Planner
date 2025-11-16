using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace Meal_Planner
{
    public partial class Form1 : Form
    {
        Form2 addForm;
        Form3 viewForm;
        Form4 mealPlanner;
        List<Recipe> recipes = new List<Recipe>();

        public Form1()
        {
            InitializeComponent();
            addForm = new Form2();
            viewForm = new Form3();
            mealPlanner = new Form4();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Close();
            FileInfo outputStatus;

            outputStatus = new FileInfo("recipebook.txt");
            if (!outputStatus.Exists)
            {
                MessageBox.Show("We fucked up, somehow the recipebook.txt file dosent exist");
            }
            else
            {
               StringBuilder sb = new StringBuilder();

                sb.Append(recipes.Count.ToString() + "\n");
                for(int i = 0; i < recipes.Count; i++)
                {
                    Recipe temp = recipes[i];
                    List<string> tempIng = temp.getIngredients();
                    List<string> tempDir = temp.getDirections();
                    sb.Append("\n");
                    sb.Append(temp.getName() + "\n");
                    sb.Append(tempIng.Count.ToString() + "\n");
                    sb.Append(tempDir.Count.ToString() + "\n");
                    for (int j = 0; j < tempIng.Count; j++)
                        sb.Append(tempIng[j] + "\n");
                    for (int k = 0; k < tempDir.Count; k++)
                        sb.Append(tempDir[k] + "\n");
                }

                string data = sb.ToString();
                File.WriteAllText(outputStatus.Name, data);
            }
        }

        private void addRecipe_Click(object sender, EventArgs e)
        {
            recipes = addForm.GetInformation(recipes);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            FileInfo inputStatus;
            StreamReader input;
            string inLine, skip;

            string name;
            int numRecipes;
            int numDirections;
            int numIngredients;
            Recipe temp;

            inputStatus = new FileInfo("recipebook.txt");
            if (!inputStatus.Exists)
            {
                File.Create("recipebook.txt");
            }
            else
            {
                input = inputStatus.OpenText();
                if (input != null)
                {
                    inLine = input.ReadLine();
                    numRecipes = Convert.ToInt32(inLine);

                    int i = 0, j = 0;
                    for (i = 0; i < numRecipes; i++)
                    {
                        List<string> ingredients = new List<string>();
                        List<string> directions = new List<string>();
                        skip = input.ReadLine();

                        name = input.ReadLine();
                        inLine = input.ReadLine();
                        numIngredients = Convert.ToInt32(inLine);
                        inLine = input.ReadLine();
                        numDirections = Convert.ToInt32(inLine);
                        for (j = 0; j < numIngredients; j++)
                        {
                            ingredients.Add(input.ReadLine());
                        }
                        for (j = 0; j < numDirections; j++)
                        {
                            directions.Add(input.ReadLine());
                        }
                        temp = new Recipe(name, ingredients, directions);
                        recipes.Add(temp);
                    }
                    input.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recipes = viewForm.showRecipes(recipes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mealPlanner.SelectedMeals(recipes);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

public class Recipe
{
    string name;
    List<string> ingredients;
    List<string> directions;

    public Recipe(string n, List<string> i, List<string> d)
    {
        this.name = n;
        this.ingredients = i;
        this.directions = d;
    }

    public string getName()
    {
        return name;
    }

    public List<string> getIngredients()
    {
        return ingredients;
    }

    public List<string> getDirections()
    {
        return directions;
    }

    public void setName(string n)
    {
        this.name = n;
    }

    public void setIngredients(List<string> i)
    {
        this.ingredients = i;
    }

    public void setDirections(List<string> d)
    {
        this.directions = d;
    }

    public override string ToString()
    {
        return name;
    }
}
