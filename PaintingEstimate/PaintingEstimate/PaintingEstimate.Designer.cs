namespace PaintingEstimate
{
    partial class PaintingEstimate
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
            lengthTextBox = new TextBox();
            widthTextBox = new TextBox();
            calculateButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(340, 122);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(150, 31);
            lengthTextBox.TabIndex = 0;
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(340, 187);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(150, 31);
            widthTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(270, 244);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(146, 51);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate Cost";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += this.calculateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 125);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 3;
            label1.Text = "Width of Room-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 193);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 4;
            label2.Text = "Length of Room-";
            // 
            // PaintingEstimate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calculateButton);
            Controls.Add(widthTextBox);
            Controls.Add(lengthTextBox);
            Name = "PaintingEstimate";
            Text = "Painting Estimate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lengthTextBox;
        private TextBox widthTextBox;
        private Button calculateButton;
        private Label label1;
        private Label label2;
    }
}
