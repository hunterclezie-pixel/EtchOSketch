namespace EtchOSketch
{
    partial class EtchOSketchForm
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
            pictureBox1 = new PictureBox();
            ExitButton = new Button();
            ClearButton = new Button();
            DrawWavefomButton = new Button();
            SelectColorButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 367);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(633, 385);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(155, 53);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(472, 385);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(155, 53);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // DrawWavefomButton
            // 
            DrawWavefomButton.Location = new Point(311, 385);
            DrawWavefomButton.Name = "DrawWavefomButton";
            DrawWavefomButton.Size = new Size(155, 53);
            DrawWavefomButton.TabIndex = 3;
            DrawWavefomButton.Text = "Draw Waveform";
            DrawWavefomButton.UseVisualStyleBackColor = true;
            // 
            // SelectColorButton
            // 
            SelectColorButton.Location = new Point(150, 385);
            SelectColorButton.Name = "SelectColorButton";
            SelectColorButton.Size = new Size(155, 53);
            SelectColorButton.TabIndex = 4;
            SelectColorButton.Text = "Select Color";
            SelectColorButton.UseVisualStyleBackColor = true;
            // 
            // EtchOSketchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SelectColorButton);
            Controls.Add(DrawWavefomButton);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(pictureBox1);
            Name = "EtchOSketchForm";
            Text = "EtchOSketchForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button ExitButton;
        private Button ClearButton;
        private Button DrawWavefomButton;
        private Button SelectColorButton;
    }
}
