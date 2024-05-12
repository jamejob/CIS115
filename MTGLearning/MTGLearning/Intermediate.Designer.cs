namespace MTGLearning
{
    partial class Intermediate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intermediate));
            Home = new Button();
            label1 = new Label();
            Stack = new Button();
            Card = new Button();
            Play = new Button();
            Phases = new Button();
            Quiz = new Button();
            SuspendLayout();
            // 
            // Home
            // 
            Home.Location = new Point(286, 765);
            Home.MaximumSize = new Size(186, 61);
            Home.Name = "Home";
            Home.Size = new Size(186, 61);
            Home.TabIndex = 0;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(274, 143);
            label1.Name = "label1";
            label1.Size = new Size(181, 45);
            label1.TabIndex = 1;
            label1.Text = "MTG Player";
            // 
            // Stack
            // 
            Stack.Location = new Point(109, 601);
            Stack.Name = "Stack";
            Stack.Size = new Size(186, 61);
            Stack.TabIndex = 2;
            Stack.Text = "The Stack";
            Stack.UseVisualStyleBackColor = true;
            Stack.Click += Stack_Click;
            // 
            // Card
            // 
            Card.Location = new Point(418, 468);
            Card.Name = "Card";
            Card.Size = new Size(186, 61);
            Card.TabIndex = 3;
            Card.Text = "In Depth Card Types";
            Card.UseVisualStyleBackColor = true;
            Card.Click += Card_Click;
            // 
            // Play
            // 
            Play.Location = new Point(452, 601);
            Play.Name = "Play";
            Play.Size = new Size(186, 61);
            Play.TabIndex = 4;
            Play.Text = "Ways to Play";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // Phases
            // 
            Phases.Location = new Point(155, 468);
            Phases.MaximumSize = new Size(186, 61);
            Phases.Name = "Phases";
            Phases.Size = new Size(186, 61);
            Phases.TabIndex = 5;
            Phases.Text = "Phases";
            Phases.UseVisualStyleBackColor = true;
            Phases.Click += Phases_Click;
            // 
            // Quiz
            // 
            Quiz.Location = new Point(286, 698);
            Quiz.Name = "Quiz";
            Quiz.Size = new Size(186, 61);
            Quiz.TabIndex = 6;
            Quiz.Text = "Quiz";
            Quiz.UseVisualStyleBackColor = true;
            Quiz.Click += Quiz_Click;
            // 
            // Intermediate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(745, 1040);
            Controls.Add(Quiz);
            Controls.Add(Phases);
            Controls.Add(Play);
            Controls.Add(Card);
            Controls.Add(Stack);
            Controls.Add(label1);
            Controls.Add(Home);
            Name = "Intermediate";
            Text = "MTG Player";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Home;
        private Label label1;
        private Button Stack;
        private Button Card;
        private Button Play;
        private Button Phases;
        private Button Quiz;
    }
}