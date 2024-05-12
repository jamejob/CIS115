namespace MTGLearning
{
    partial class MTGLearning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTGLearning));
            Intro = new Button();
            Begin = new Button();
            Inter = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Intro
            // 
            Intro.Location = new Point(280, 420);
            Intro.Name = "Intro";
            Intro.Size = new Size(186, 61);
            Intro.TabIndex = 0;
            Intro.Text = "Introduction";
            Intro.UseVisualStyleBackColor = true;
            Intro.Click += Intro_Click;
            // 
            // Begin
            // 
            Begin.Location = new Point(109, 590);
            Begin.Name = "Begin";
            Begin.Size = new Size(186, 61);
            Begin.TabIndex = 1;
            Begin.Text = "Beginner";
            Begin.UseVisualStyleBackColor = true;
            Begin.Click += Begin_Click;
            // 
            // Inter
            // 
            Inter.Location = new Point(450, 580);
            Inter.Name = "Inter";
            Inter.Size = new Size(186, 61);
            Inter.TabIndex = 2;
            Inter.Text = "MTG Player";
            Inter.UseVisualStyleBackColor = true;
            Inter.Click += Inter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(121, 145);
            label1.Name = "label1";
            label1.Size = new Size(505, 45);
            label1.TabIndex = 6;
            label1.Text = "Magic The Gathering Learning Aid";
            // 
            // MTGLearning
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(744, 1030);
            Controls.Add(label1);
            Controls.Add(Inter);
            Controls.Add(Begin);
            Controls.Add(Intro);
            Name = "MTGLearning";
            Text = "MTG Learning Assist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Intro;
        private Button Begin;
        private Button Inter;
        private Label label1;
    }
}
