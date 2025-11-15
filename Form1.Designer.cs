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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addRecipe
            // 
            addRecipe.Location = new Point(33, 117);
            addRecipe.Name = "addRecipe";
            addRecipe.Size = new Size(192, 52);
            addRecipe.TabIndex = 0;
            addRecipe.Text = "Add Recipes";
            addRecipe.UseVisualStyleBackColor = true;
            addRecipe.Click += addRecipe_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 33);
            button2.Name = "button2";
            button2.Size = new Size(192, 52);
            button2.TabIndex = 1;
            button2.Text = "Recipe Book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(33, 201);
            button3.Name = "button3";
            button3.Size = new Size(192, 52);
            button3.TabIndex = 2;
            button3.Text = "Plan Meals";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(33, 285);
            button4.Name = "button4";
            button4.Size = new Size(192, 52);
            button4.TabIndex = 3;
            button4.Text = "Grocery List";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(33, 369);
            button5.Name = "button5";
            button5.Size = new Size(192, 52);
            button5.TabIndex = 4;
            button5.Text = "Close";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(511, 313);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(addRecipe);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Master Your Meals";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addRecipe;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
    }
}
