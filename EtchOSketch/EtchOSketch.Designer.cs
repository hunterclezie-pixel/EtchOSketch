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
            DisplayMainMenuStrip = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            ExitMainStripItem = new ToolStripMenuItem();
            EditMainStripItem = new ToolStripMenuItem();
            SelectColorMainStripItem = new ToolStripMenuItem();
            DrawWaveformMainStripItem = new ToolStripMenuItem();
            ClearMainStripItem = new ToolStripMenuItem();
            HelpMainStripItem = new ToolStripMenuItem();
            AboutMainStripItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            DisplayContextMenuStrip.SuspendLayout();
            DisplayMainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = Color.White;
            DisplayPictureBox.Location = new Point(12, 31);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(776, 348);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            DrawWavefomButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            SelectColorButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            DisplayContextMenuStrip.Size = new Size(111, 76);
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(110, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // ExitStripMenuItem
            // 
            ExitStripMenuItem.Name = "ExitStripMenuItem";
            ExitStripMenuItem.Size = new Size(116, 26);
            ExitStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SelectColorStripMenuItem, DrawWaveformStripMenuItem, ClearStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(110, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // SelectColorStripMenuItem
            // 
            SelectColorStripMenuItem.Name = "SelectColorStripMenuItem";
            SelectColorStripMenuItem.Size = new Size(199, 26);
            SelectColorStripMenuItem.Text = "Select Color";
            // 
            // DrawWaveformStripMenuItem
            // 
            DrawWaveformStripMenuItem.Name = "DrawWaveformStripMenuItem";
            DrawWaveformStripMenuItem.Size = new Size(199, 26);
            DrawWaveformStripMenuItem.Text = "Draw Waveform";
            // 
            // ClearStripMenuItem
            // 
            ClearStripMenuItem.Name = "ClearStripMenuItem";
            ClearStripMenuItem.Size = new Size(199, 26);
            ClearStripMenuItem.Text = "Clear";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(110, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // AboutStripMenuItem
            // 
            AboutStripMenuItem.Name = "AboutStripMenuItem";
            AboutStripMenuItem.Size = new Size(133, 26);
            AboutStripMenuItem.Text = "About";
            AboutStripMenuItem.Click += AboutStripMenuItem_Click;
            // 
            // DisplayMainMenuStrip
            // 
            DisplayMainMenuStrip.ImageScalingSize = new Size(20, 20);
            DisplayMainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, EditMainStripItem, HelpMainStripItem });
            DisplayMainMenuStrip.Location = new Point(0, 0);
            DisplayMainMenuStrip.Name = "DisplayMainMenuStrip";
            DisplayMainMenuStrip.Size = new Size(800, 28);
            DisplayMainMenuStrip.TabIndex = 5;
            DisplayMainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ExitMainStripItem });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(46, 24);
            fileToolStripMenuItem1.Text = "File";
            // 
            // ExitMainStripItem
            // 
            ExitMainStripItem.Name = "ExitMainStripItem";
            ExitMainStripItem.Size = new Size(116, 26);
            ExitMainStripItem.Text = "Exit";
            // 
            // EditMainStripItem
            // 
            EditMainStripItem.DropDownItems.AddRange(new ToolStripItem[] { SelectColorMainStripItem, DrawWaveformMainStripItem, ClearMainStripItem });
            EditMainStripItem.Name = "EditMainStripItem";
            EditMainStripItem.Size = new Size(49, 24);
            EditMainStripItem.Text = "Edit";
            // 
            // SelectColorMainStripItem
            // 
            SelectColorMainStripItem.Name = "SelectColorMainStripItem";
            SelectColorMainStripItem.Size = new Size(199, 26);
            SelectColorMainStripItem.Text = "Select Color";
            // 
            // DrawWaveformMainStripItem
            // 
            DrawWaveformMainStripItem.Name = "DrawWaveformMainStripItem";
            DrawWaveformMainStripItem.Size = new Size(199, 26);
            DrawWaveformMainStripItem.Text = "Draw Waveform";
            // 
            // ClearMainStripItem
            // 
            ClearMainStripItem.Name = "ClearMainStripItem";
            ClearMainStripItem.Size = new Size(199, 26);
            ClearMainStripItem.Text = "Clear";
            // 
            // HelpMainStripItem
            // 
            HelpMainStripItem.DropDownItems.AddRange(new ToolStripItem[] { AboutMainStripItem });
            HelpMainStripItem.Name = "HelpMainStripItem";
            HelpMainStripItem.Size = new Size(55, 24);
            HelpMainStripItem.Text = "Help";
            // 
            // AboutMainStripItem
            // 
            AboutMainStripItem.Name = "AboutMainStripItem";
            AboutMainStripItem.Size = new Size(133, 26);
            AboutMainStripItem.Text = "About";
            // 
            // EtchOSketchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayMainMenuStrip);
            Controls.Add(SelectColorButton);
            Controls.Add(DrawWavefomButton);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(DisplayPictureBox);
            MainMenuStrip = DisplayMainMenuStrip;
            Name = "EtchOSketchForm";
            Text = "EtchOSketchForm";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            DisplayContextMenuStrip.ResumeLayout(false);
            DisplayMainMenuStrip.ResumeLayout(false);
            DisplayMainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private MenuStrip DisplayMainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem ExitMainStripItem;
        private ToolStripMenuItem EditMainStripItem;
        private ToolStripMenuItem SelectColorMainStripItem;
        private ToolStripMenuItem DrawWaveformMainStripItem;
        private ToolStripMenuItem ClearMainStripItem;
        private ToolStripMenuItem HelpMainStripItem;
        private ToolStripMenuItem AboutMainStripItem;
    }
}
