 namespace Vexillology_v4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            optionsComboBox = new ComboBox();
            playButton = new Button();
            americaPictureBox = new PictureBox();
            titleLabel = new Label();
            WorldPictureBox = new PictureBox();
            selectLabel = new Label();
            linkLabel1 = new LinkLabel();
            elSalvadorPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)americaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WorldPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)elSalvadorPictureBox).BeginInit();
            SuspendLayout();
            // 
            // optionsComboBox
            // 
            optionsComboBox.FormattingEnabled = true;
            optionsComboBox.Location = new Point(297, 222);
            optionsComboBox.Name = "optionsComboBox";
            optionsComboBox.Size = new Size(121, 23);
            optionsComboBox.TabIndex = 0;
            // 
            // playButton
            // 
            playButton.Location = new Point(297, 356);
            playButton.Name = "playButton";
            playButton.Size = new Size(121, 46);
            playButton.TabIndex = 1;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            // 
            // americaPictureBox
            // 
            americaPictureBox.Image = (Image)resources.GetObject("americaPictureBox.Image");
            americaPictureBox.Location = new Point(87, 143);
            americaPictureBox.Name = "americaPictureBox";
            americaPictureBox.Size = new Size(169, 186);
            americaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            americaPictureBox.TabIndex = 2;
            americaPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Impact", 40.25F);
            titleLabel.Location = new Point(214, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(342, 66);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Guess the flag";
            // 
            // WorldPictureBox
            // 
            WorldPictureBox.Image = (Image)resources.GetObject("WorldPictureBox.Image");
            WorldPictureBox.Location = new Point(466, 143);
            WorldPictureBox.Name = "WorldPictureBox";
            WorldPictureBox.Size = new Size(249, 186);
            WorldPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            WorldPictureBox.TabIndex = 4;
            WorldPictureBox.TabStop = false;
            // 
            // selectLabel
            // 
            selectLabel.AutoSize = true;
            selectLabel.Font = new Font("Segoe UI", 15F);
            selectLabel.Location = new Point(267, 102);
            selectLabel.Name = "selectLabel";
            selectLabel.Size = new Size(184, 28);
            selectLabel.TabIndex = 5;
            selectLabel.Text = "Select a gamemode";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.Location = new Point(674, 422);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 19);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "About vexillology";
            linkLabel1.DoubleClick += linkLabel1_DoubleClick;
            // 
            // elSalvadorPictureBox
            // 
            elSalvadorPictureBox.Image = (Image)resources.GetObject("elSalvadorPictureBox.Image");
            elSalvadorPictureBox.Location = new Point(12, 388);
            elSalvadorPictureBox.Name = "elSalvadorPictureBox";
            elSalvadorPictureBox.Size = new Size(87, 50);
            elSalvadorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            elSalvadorPictureBox.TabIndex = 8;
            elSalvadorPictureBox.TabStop = false;
            elSalvadorPictureBox.MouseLeave += elSalvadorPictureBox_MouseLeave;
            elSalvadorPictureBox.MouseHover += elSalvadorPictureBox_MouseHover;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(elSalvadorPictureBox);
            Controls.Add(linkLabel1);
            Controls.Add(selectLabel);
            Controls.Add(WorldPictureBox);
            Controls.Add(titleLabel);
            Controls.Add(americaPictureBox);
            Controls.Add(playButton);
            Controls.Add(optionsComboBox);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)americaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)WorldPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)elSalvadorPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox optionsComboBox;
        private Button playButton;
        private PictureBox americaPictureBox;
        private Label titleLabel;
        private PictureBox WorldPictureBox;
        private Label selectLabel;
        private LinkLabel linkLabel1;
        private PictureBox elSalvadorPictureBox;
    }
}
