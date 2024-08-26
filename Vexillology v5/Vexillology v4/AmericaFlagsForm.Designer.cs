namespace Vexillology_v4
{
    partial class AmericaFlagsForm
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmericaFlagsForm));
            AmericaComboBox = new ComboBox();
            AmericaConfirmButton = new Button();
            americaResultsLabel = new Label();
            paraguayPictureBox = new PictureBox();
            cubaPictureBox = new PictureBox();
            americaTitleLabel = new Label();
            arubaPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)paraguayPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cubaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arubaPictureBox).BeginInit();
            SuspendLayout();
            // 
            // AmericaComboBox
            // 
            AmericaComboBox.FormattingEnabled = true;
            AmericaComboBox.Location = new Point(296, 232);
            AmericaComboBox.Name = "AmericaComboBox";
            AmericaComboBox.Size = new Size(216, 23);
            AmericaComboBox.TabIndex = 0;

            // 
            // AmericaConfirmButton
            // 
            AmericaConfirmButton.AllowDrop = true;
            AmericaConfirmButton.Location = new Point(367, 278);
            AmericaConfirmButton.Name = "AmericaConfirmButton";
            AmericaConfirmButton.Size = new Size(75, 23);
            AmericaConfirmButton.TabIndex = 1;
            AmericaConfirmButton.Text = "Confirm";
            AmericaConfirmButton.UseVisualStyleBackColor = true;
            AmericaConfirmButton.Click += AmericaConfirmButton_Click;

            // 
            // americaResultsLabel
            // 
            americaResultsLabel.AutoSize = true;
            americaResultsLabel.Location = new Point(62, 319);
            americaResultsLabel.Name = "americaResultsLabel";
            americaResultsLabel.Size = new Size(15, 15);
            americaResultsLabel.TabIndex = 2;
            americaResultsLabel.Text = ">";
            // 
            // paraguayPictureBox
            // 
            paraguayPictureBox.Image = (Image)resources.GetObject("paraguayPictureBox.Image");
            paraguayPictureBox.Location = new Point(307, 78);
            paraguayPictureBox.Name = "paraguayPictureBox";
            paraguayPictureBox.Size = new Size(196, 126);
            paraguayPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            paraguayPictureBox.TabIndex = 4;
            paraguayPictureBox.TabStop = false;
            // 
            // cubaPictureBox
            // 
            cubaPictureBox.Image = (Image)resources.GetObject("cubaPictureBox.Image");
            cubaPictureBox.Location = new Point(563, 78);
            cubaPictureBox.Name = "cubaPictureBox";
            cubaPictureBox.Size = new Size(196, 126);
            cubaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cubaPictureBox.TabIndex = 5;
            cubaPictureBox.TabStop = false;
            // 
            // americaTitleLabel
            // 
            americaTitleLabel.AutoSize = true;
            americaTitleLabel.Location = new Point(367, 31);
            americaTitleLabel.Name = "americaTitleLabel";
            americaTitleLabel.Size = new Size(82, 15);
            americaTitleLabel.TabIndex = 6;
            americaTitleLabel.Text = "Choose wisely";
            // 
            // arubaPictureBox
            // 
            arubaPictureBox.Image = (Image)resources.GetObject("arubaPictureBox.Image");
            arubaPictureBox.Location = new Point(62, 78);
            arubaPictureBox.Name = "arubaPictureBox";
            arubaPictureBox.Size = new Size(196, 126);
            arubaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            arubaPictureBox.TabIndex = 7;
            arubaPictureBox.TabStop = false;
            // 
            // AmericaFlagsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(arubaPictureBox);
            Controls.Add(americaTitleLabel);
            Controls.Add(cubaPictureBox);
            Controls.Add(paraguayPictureBox);
            Controls.Add(americaResultsLabel);
            Controls.Add(AmericaConfirmButton);
            Controls.Add(AmericaComboBox);
            Name = "AmericaFlagsForm";
            Text = "AmericaFlagsForm";
            ((System.ComponentModel.ISupportInitialize)paraguayPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cubaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)arubaPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox AmericaComboBox;
        private Button AmericaConfirmButton;
        private Label americaResultsLabel;
        private PictureBox paraguayPictureBox;
        private PictureBox cubaPictureBox;
        private Label americaTitleLabel;
        private PictureBox arubaPictureBox;
    }
}