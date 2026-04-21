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
            components = new System.ComponentModel.Container();
            DisplayPictureBox = new PictureBox();
            ExitButton = new Button();
            ClearButton = new Button();
            DrawWavefomButton = new Button();
            SelectColorButton = new Button();
            PenColorDialog = new ColorDialog();
            DisplayContextMenuStrip = new ContextMenuStrip(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            ExitStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            SelectColorStripMenuItem = new ToolStripMenuItem();
            DrawWaveformStripMenuItem = new ToolStripMenuItem();
            ClearStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            AboutStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            DisplayContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.BackColor = Color.White;
            DisplayPictureBox.Location = new Point(12, 12);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(776, 367);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(633, 385);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(155, 53);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(472, 385);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(155, 53);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // DrawWavefomButton
            // 
            DrawWavefomButton.Location = new Point(311, 385);
            DrawWavefomButton.Name = "DrawWavefomButton";
            DrawWavefomButton.Size = new Size(155, 53);
            DrawWavefomButton.TabIndex = 3;
            DrawWavefomButton.Text = "Draw Waveform";
            DrawWavefomButton.UseVisualStyleBackColor = true;
            DrawWavefomButton.Click += DrawWavefomButton_Click;
            // 
            // SelectColorButton
            // 
            SelectColorButton.Location = new Point(150, 385);
            SelectColorButton.Name = "SelectColorButton";
            SelectColorButton.Size = new Size(155, 53);
            SelectColorButton.TabIndex = 4;
            SelectColorButton.Text = "Select Color";
            SelectColorButton.UseVisualStyleBackColor = true;
            SelectColorButton.Click += SelectColorButton_Click;
            // 
            // DisplayContextMenuStrip
            // 
            DisplayContextMenuStrip.ImageScalingSize = new Size(20, 20);
            DisplayContextMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            DisplayContextMenuStrip.Name = "DisplayContextMenuStrip";
            DisplayContextMenuStrip.Size = new Size(211, 104);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(210, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // ExitStripMenuItem
            // 
            ExitStripMenuItem.Name = "ExitStripMenuItem";
            ExitStripMenuItem.Size = new Size(224, 26);
            ExitStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SelectColorStripMenuItem, DrawWaveformStripMenuItem, ClearStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(210, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // SelectColorStripMenuItem
            // 
            SelectColorStripMenuItem.Name = "SelectColorStripMenuItem";
            SelectColorStripMenuItem.Size = new Size(224, 26);
            SelectColorStripMenuItem.Text = "Select Color";
            // 
            // DrawWaveformStripMenuItem
            // 
            DrawWaveformStripMenuItem.Name = "DrawWaveformStripMenuItem";
            DrawWaveformStripMenuItem.Size = new Size(224, 26);
            DrawWaveformStripMenuItem.Text = "Draw Waveform";
            // 
            // ClearStripMenuItem
            // 
            ClearStripMenuItem.Name = "ClearStripMenuItem";
            ClearStripMenuItem.Size = new Size(224, 26);
            ClearStripMenuItem.Text = "Clear";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(210, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // AboutStripMenuItem
            // 
            AboutStripMenuItem.Name = "AboutStripMenuItem";
            AboutStripMenuItem.Size = new Size(224, 26);
            AboutStripMenuItem.Text = "About";
            AboutStripMenuItem.Click += AboutStripMenuItem_Click;
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
            Controls.Add(DisplayPictureBox);
            Name = "EtchOSketchForm";
            Text = "EtchOSketchForm";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            DisplayContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox DisplayPictureBox;
        private Button ExitButton;
        private Button ClearButton;
        private Button DrawWavefomButton;
        private Button SelectColorButton;
        private ColorDialog PenColorDialog;
        private ContextMenuStrip DisplayContextMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ExitStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem SelectColorStripMenuItem;
        private ToolStripMenuItem DrawWaveformStripMenuItem;
        private ToolStripMenuItem ClearStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem AboutStripMenuItem;
    }
}
