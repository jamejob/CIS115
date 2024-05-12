namespace MTGLearning
{
    partial class Beginner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beginner));
            Home = new Button();
            Lands = new Button();
            Basics = new Button();
            Building = new Button();
            Game = new Button();
            Quiz = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Home
            // 
            Home.Location = new Point(287, 773);
            Home.MaximumSize = new Size(186, 61);
            Home.Name = "Home";
            Home.Size = new Size(186, 61);
            Home.TabIndex = 0;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // Lands
            // 
            Lands.Location = new Point(142, 435);
            Lands.Name = "Lands";
            Lands.Size = new Size(186, 61);
            Lands.TabIndex = 1;
            Lands.Text = "Lands";
            Lands.UseVisualStyleBackColor = true;
            Lands.Click += Lands_Click;
            // 
            // Basics
            // 
            Basics.Location = new Point(108, 586);
            Basics.MaximumSize = new Size(186, 61);
            Basics.Name = "Basics";
            Basics.Size = new Size(186, 61);
            Basics.TabIndex = 2;
            Basics.Text = "Card Basics";
            Basics.UseVisualStyleBackColor = true;
            Basics.Click += Basics_Click;
            // 
            // Building
            // 
            Building.Location = new Point(431, 435);
            Building.MaximumSize = new Size(186, 61);
            Building.Name = "Building";
            Building.Size = new Size(186, 61);
            Building.TabIndex = 3;
            Building.Text = "Deck Building";
            Building.UseVisualStyleBackColor = true;
            Building.Click += Building_Click;
            // 
            // Game
            // 
            Game.Location = new Point(448, 586);
            Game.MaximumSize = new Size(186, 61);
            Game.Name = "Game";
            Game.Size = new Size(186, 61);
            Game.TabIndex = 4;
            Game.Text = "Beginner Game";
            Game.UseVisualStyleBackColor = true;
            Game.Click += Game_Click;
            // 
            // Quiz
            // 
            Quiz.Location = new Point(287, 706);
            Quiz.MaximumSize = new Size(186, 61);
            Quiz.Name = "Quiz";
            Quiz.Size = new Size(186, 61);
            Quiz.TabIndex = 5;
            Quiz.Text = "Quiz";
            Quiz.UseVisualStyleBackColor = true;
            Quiz.Click += Quiz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(308, 147);
            label1.Name = "label1";
            label1.Size = new Size(146, 45);
            label1.TabIndex = 6;
            label1.Text = "Beginner";
            // 
            // Beginner
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(746, 1026);
            Controls.Add(label1);
            Controls.Add(Quiz);
            Controls.Add(Game);
            Controls.Add(Building);
            Controls.Add(Basics);
            Controls.Add(Lands);
            Controls.Add(Home);
            Name = "Beginner";
            Text = "Beginner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Home;
        private Button Lands;
        private Button Basics;
        private Button Building;
        private Button Game;
        private Button Quiz;
        private Label label1;
    }
}