namespace Meal_Planner
{
    partial class Form2
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
            label25 = new Label();
            recipeName = new TextBox();
            doneAdding = new Button();
            resetButton = new Button();
            addToRecipebook = new Button();
            ingredientsBox = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            doneIngredientsButton = new Button();
            addIngredientsButton = new Button();
            label3 = new Label();
            addIngredients = new Button();
            listBox2 = new ListBox();
            label2 = new Label();
            addDirections = new Button();
            panel2 = new Panel();
            label5 = new Label();
            doneDirectionButton = new Button();
            addDirectionButton = new Button();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            deleteIngredient = new Button();
            deleteDirections = new Button();
            finishedEditing = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(24, 25);
            label25.Name = "label25";
            label25.Size = new Size(101, 20);
            label25.TabIndex = 6;
            label25.Text = "Recipe Name:";
            // 
            // recipeName
            // 
            recipeName.Location = new Point(133, 18);
            recipeName.Name = "recipeName";
            recipeName.Size = new Size(170, 27);
            recipeName.TabIndex = 7;
            // 
            // doneAdding
            // 
            doneAdding.Location = new Point(38, 452);
            doneAdding.Name = "doneAdding";
            doneAdding.Size = new Size(213, 41);
            doneAdding.TabIndex = 8;
            doneAdding.Text = "Done";
            doneAdding.UseVisualStyleBackColor = true;
            doneAdding.Click += button1_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(329, 452);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(213, 41);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += button2_Click;
            // 
            // addToRecipebook
            // 
            addToRecipebook.Location = new Point(604, 452);
            addToRecipebook.Name = "addToRecipebook";
            addToRecipebook.Size = new Size(213, 41);
            addToRecipebook.TabIndex = 10;
            addToRecipebook.Text = "Add To Recipebook";
            addToRecipebook.UseVisualStyleBackColor = true;
            addToRecipebook.Click += button3_Click;
            // 
            // ingredientsBox
            // 
            ingredientsBox.FormattingEnabled = true;
            ingredientsBox.Location = new Point(24, 102);
            ingredientsBox.Name = "ingredientsBox";
            ingredientsBox.Size = new Size(327, 304);
            ingredientsBox.TabIndex = 11;
            ingredientsBox.DoubleClick += listBox1_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 12;
            label1.Text = "Ingredient:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(doneIngredientsButton);
            panel1.Controls.Add(addIngredientsButton);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Enabled = false;
            panel1.Location = new Point(348, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 128);
            panel1.TabIndex = 14;
            panel1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 0);
            label6.Name = "label6";
            label6.Size = new Size(152, 28);
            label6.TabIndex = 16;
            label6.Text = "Add Ingredients";
            // 
            // doneIngredientsButton
            // 
            doneIngredientsButton.Location = new Point(171, 91);
            doneIngredientsButton.Name = "doneIngredientsButton";
            doneIngredientsButton.Size = new Size(94, 29);
            doneIngredientsButton.TabIndex = 15;
            doneIngredientsButton.Text = "Done";
            doneIngredientsButton.UseVisualStyleBackColor = true;
            doneIngredientsButton.Click += button5_Click;
            // 
            // addIngredientsButton
            // 
            addIngredientsButton.Location = new Point(19, 91);
            addIngredientsButton.Name = "addIngredientsButton";
            addIngredientsButton.Size = new Size(125, 29);
            addIngredientsButton.TabIndex = 14;
            addIngredientsButton.Text = "Add Ingredient";
            addIngredientsButton.UseVisualStyleBackColor = true;
            addIngredientsButton.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 72);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 15;
            label3.Text = "Ingredients";
            // 
            // addIngredients
            // 
            addIngredients.Location = new Point(171, 67);
            addIngredients.Name = "addIngredients";
            addIngredients.Size = new Size(72, 29);
            addIngredients.TabIndex = 16;
            addIngredients.Text = "Add";
            addIngredients.UseVisualStyleBackColor = true;
            addIngredients.Click += button6_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(408, 102);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(409, 304);
            listBox2.TabIndex = 17;
            listBox2.DoubleClick += listBox2_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 71);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 18;
            label2.Text = "Directions";
            // 
            // addDirections
            // 
            addDirections.Location = new Point(637, 67);
            addDirections.Name = "addDirections";
            addDirections.Size = new Size(66, 29);
            addDirections.TabIndex = 19;
            addDirections.Text = "Add";
            addDirections.UseVisualStyleBackColor = true;
            addDirections.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(doneDirectionButton);
            panel2.Controls.Add(addDirectionButton);
            panel2.Controls.Add(richTextBox1);
            panel2.Controls.Add(label4);
            panel2.Enabled = false;
            panel2.Location = new Point(47, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 180);
            panel2.TabIndex = 20;
            panel2.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 10);
            label5.Name = "label5";
            label5.Size = new Size(142, 28);
            label5.TabIndex = 4;
            label5.Text = "Add Directions";
            // 
            // doneDirectionButton
            // 
            doneDirectionButton.Location = new Point(250, 143);
            doneDirectionButton.Name = "doneDirectionButton";
            doneDirectionButton.Size = new Size(94, 29);
            doneDirectionButton.TabIndex = 3;
            doneDirectionButton.Text = "Done";
            doneDirectionButton.UseVisualStyleBackColor = true;
            doneDirectionButton.Click += button9_Click;
            // 
            // addDirectionButton
            // 
            addDirectionButton.Location = new Point(28, 143);
            addDirectionButton.Name = "addDirectionButton";
            addDirectionButton.Size = new Size(124, 29);
            addDirectionButton.TabIndex = 2;
            addDirectionButton.Text = "Add DIrection";
            addDirectionButton.UseVisualStyleBackColor = true;
            addDirectionButton.Click += button8_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(89, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(255, 77);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 50);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 0;
            label4.Text = "Direction:";
            // 
            // deleteIngredient
            // 
            deleteIngredient.Location = new Point(257, 67);
            deleteIngredient.Name = "deleteIngredient";
            deleteIngredient.Size = new Size(78, 29);
            deleteIngredient.TabIndex = 21;
            deleteIngredient.Text = "Delete";
            deleteIngredient.UseVisualStyleBackColor = true;
            deleteIngredient.Click += button10_Click;
            // 
            // deleteDirections
            // 
            deleteDirections.Location = new Point(727, 68);
            deleteDirections.Name = "deleteDirections";
            deleteDirections.Size = new Size(81, 29);
            deleteDirections.TabIndex = 22;
            deleteDirections.Text = "Delete";
            deleteDirections.UseVisualStyleBackColor = true;
            deleteDirections.Click += button11_Click;
            // 
            // finishedEditing
            // 
            finishedEditing.Enabled = false;
            finishedEditing.Location = new Point(38, 439);
            finishedEditing.Name = "finishedEditing";
            finishedEditing.Size = new Size(213, 42);
            finishedEditing.TabIndex = 23;
            finishedEditing.Text = "Finished";
            finishedEditing.UseVisualStyleBackColor = true;
            finishedEditing.Visible = false;
            finishedEditing.Click += button12_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 505);
            Controls.Add(panel1);
            Controls.Add(finishedEditing);
            Controls.Add(deleteDirections);
            Controls.Add(deleteIngredient);
            Controls.Add(panel2);
            Controls.Add(addDirections);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(addIngredients);
            Controls.Add(label3);
            Controls.Add(ingredientsBox);
            Controls.Add(addToRecipebook);
            Controls.Add(resetButton);
            Controls.Add(doneAdding);
            Controls.Add(recipeName);
            Controls.Add(label25);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Recipes";
            TopMost = true;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label25;
        private TextBox recipeName;
        private Button doneAdding;
        private Button resetButton;
        private Button addToRecipebook;
        private ListBox ingredientsBox;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Button doneIngredientsButton;
        private Button addIngredientsButton;
        private Label label3;
        private Button addIngredients;
        private ListBox listBox2;
        private Label label2;
        private Button addDirections;
        private Panel panel2;
        private Button addDirectionButton;
        private RichTextBox richTextBox1;
        private Label label4;
        private Button doneDirectionButton;
        private Label label6;
        private Label label5;
        private Button deleteIngredient;
        private Button deleteDirections;
        private Button finishedEditing;
    }
}