namespace Meal_Planner
{
    partial class Form1
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
            addRecipe = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // addRecipe
            // 
            addRecipe.Location = new Point(33, 109);
            addRecipe.Name = "addRecipe";
            addRecipe.Size = new Size(447, 55);
            addRecipe.TabIndex = 0;
            addRecipe.Text = "Add Recipes";
            addRecipe.UseVisualStyleBackColor = true;
            addRecipe.Click += addRecipe_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 23);
            button2.Name = "button2";
            button2.Size = new Size(447, 55);
            button2.TabIndex = 1;
            button2.Text = "Recipe Book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(33, 209);
            button3.Name = "button3";
            button3.Size = new Size(447, 55);
            button3.TabIndex = 2;
            button3.Text = "Plan Meals";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(33, 304);
            button4.Name = "button4";
            button4.Size = new Size(447, 55);
            button4.TabIndex = 3;
            button4.Text = "Create Grocery List";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(33, 405);
            button5.Name = "button5";
            button5.Size = new Size(447, 55);
            button5.TabIndex = 4;
            button5.Text = "Close";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 489);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(addRecipe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Master Your Meals";
            Shown += Form1_Shown;
            ResumeLayout(false);
        }

        #endregion

        private Button addRecipe;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
