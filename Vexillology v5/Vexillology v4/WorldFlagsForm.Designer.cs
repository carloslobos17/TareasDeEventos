namespace Vexillology_v4
{
    partial class WorldFlagsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldFlagsForm));
            worldComboBox = new ComboBox();
            worldConfirmButton = new Button();
            worldResultsLabel = new Label();
            nepalPictureBox = new PictureBox();
            nigeriaPictureBox = new PictureBox();
            newZealandPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nepalPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nigeriaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newZealandPictureBox).BeginInit();
            SuspendLayout();
            // 
            // worldComboBox
            // 
            worldComboBox.FormattingEnabled = true;
            worldComboBox.ImeMode = ImeMode.Off;
            worldComboBox.Location = new Point(290, 207);
            worldComboBox.Name = "worldComboBox";
            worldComboBox.Size = new Size(205, 23);
            worldComboBox.TabIndex = 1;
            // 
            // worldConfirmButton
            // 
            worldConfirmButton.Location = new Point(350, 255);
            worldConfirmButton.Name = "worldConfirmButton";
            worldConfirmButton.Size = new Size(75, 23);
            worldConfirmButton.TabIndex = 2;
            worldConfirmButton.Text = "Confirm";
            worldConfirmButton.UseVisualStyleBackColor = true;
            worldConfirmButton.Click += worldConfirmButton_Click;
            // 
            // worldResultsLabel
            // 
            worldResultsLabel.AutoSize = true;
            worldResultsLabel.Location = new Point(38, 320);
            worldResultsLabel.Name = "worldResultsLabel";
            worldResultsLabel.Size = new Size(15, 15);
            worldResultsLabel.TabIndex = 3;
            worldResultsLabel.Text = ">";
            // 
            // nepalPictureBox
            // 
            nepalPictureBox.Image = (Image)resources.GetObject("nepalPictureBox.Image");
            nepalPictureBox.Location = new Point(106, 41);
            nepalPictureBox.Name = "nepalPictureBox";
            nepalPictureBox.Size = new Size(94, 121);
            nepalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            nepalPictureBox.TabIndex = 4;
            nepalPictureBox.TabStop = false;
            // 
            // nigeriaPictureBox
            // 
            nigeriaPictureBox.Image = (Image)resources.GetObject("nigeriaPictureBox.Image");
            nigeriaPictureBox.Location = new Point(302, 41);
            nigeriaPictureBox.Name = "nigeriaPictureBox";
            nigeriaPictureBox.Size = new Size(184, 121);
            nigeriaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            nigeriaPictureBox.TabIndex = 5;
            nigeriaPictureBox.TabStop = false;
            // 
            // newZealandPictureBox
            // 
            newZealandPictureBox.Image = (Image)resources.GetObject("newZealandPictureBox.Image");
            newZealandPictureBox.Location = new Point(548, 41);
            newZealandPictureBox.Name = "newZealandPictureBox";
            newZealandPictureBox.Size = new Size(184, 121);
            newZealandPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            newZealandPictureBox.TabIndex = 6;
            newZealandPictureBox.TabStop = false;
            // 
            // WorldFlagsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(newZealandPictureBox);
            Controls.Add(nigeriaPictureBox);
            Controls.Add(nepalPictureBox);
            Controls.Add(worldResultsLabel);
            Controls.Add(worldConfirmButton);
            Controls.Add(worldComboBox);
            Name = "WorldFlagsForm";
            Text = "WorldFlagsForm";
            ((System.ComponentModel.ISupportInitialize)nepalPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nigeriaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)newZealandPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox worldComboBox;
        private Button worldConfirmButton;
        private Label worldResultsLabel;
        private PictureBox nepalPictureBox;
        private PictureBox nigeriaPictureBox;
        private PictureBox newZealandPictureBox;
    }
}