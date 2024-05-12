namespace MTGLearning
{
    partial class Phases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phases));
            pictureBox1 = new PictureBox();
            Back = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(845, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(746, 1104);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Back
            // 
            Back.Location = new Point(1130, 1304);
            Back.MaximumSize = new Size(186, 61);
            Back.Name = "Back";
            Back.Size = new Size(186, 61);
            Back.TabIndex = 1;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(29, 91);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(799, 1293);
            textBox1.TabIndex = 2;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(1073, 100);
            label1.Name = "label1";
            label1.Size = new Size(308, 54);
            label1.TabIndex = 3;
            label1.Text = "Phases in Depth";
            // 
            // Phases
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1603, 1405);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Back);
            Controls.Add(pictureBox1);
            Name = "Phases";
            Text = "Phases";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Back;
        private TextBox textBox1;
        private Label label1;
    }
}