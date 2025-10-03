namespace Inlämningsuppgift2
{
    partial class Form4Complete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4Complete));
            labelHeader = new Label();
            pictureBox1 = new PictureBox();
            buttonPlayAgain = new Button();
            buttonExit = new Button();
            labelCurrentScore = new Label();
            labelMessage = new Label();
            labelTotalScore = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.Dock = DockStyle.Top;
            labelHeader.Font = new Font("Bernard MT Condensed", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(0, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(741, 95);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "WIN!";
            labelHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(495, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonPlayAgain
            // 
            buttonPlayAgain.BackColor = Color.SaddleBrown;
            buttonPlayAgain.FlatAppearance.BorderSize = 0;
            buttonPlayAgain.FlatStyle = FlatStyle.Flat;
            buttonPlayAgain.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonPlayAgain.ForeColor = SystemColors.ControlLightLight;
            buttonPlayAgain.Location = new Point(252, 314);
            buttonPlayAgain.Name = "buttonPlayAgain";
            buttonPlayAgain.Size = new Size(119, 29);
            buttonPlayAgain.TabIndex = 2;
            buttonPlayAgain.Text = "Play Again";
            buttonPlayAgain.UseVisualStyleBackColor = true;
            buttonPlayAgain.Click += buttonPlayAgain_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.SaddleBrown;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExit.ForeColor = SystemColors.ControlLightLight;
            buttonExit.Location = new Point(386, 314);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelCurrentScore
            // 
            labelCurrentScore.AutoSize = true;
            labelCurrentScore.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCurrentScore.Location = new Point(287, 202);
            labelCurrentScore.Name = "labelCurrentScore";
            labelCurrentScore.Size = new Size(150, 28);
            labelCurrentScore.TabIndex = 0;
            labelCurrentScore.Text = "Current score: 0";
            labelCurrentScore.Click += labelCurrentScore_Click;
            // 
            // labelMessage
            // 
            labelMessage.Dock = DockStyle.Top;
            labelMessage.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.Location = new Point(0, 95);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(741, 36);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "My Score";
            labelMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelTotalScore
            // 
            labelTotalScore.AutoSize = true;
            labelTotalScore.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalScore.Location = new Point(287, 248);
            labelTotalScore.Name = "labelTotalScore";
            labelTotalScore.Size = new Size(132, 28);
            labelTotalScore.TabIndex = 0;
            labelTotalScore.Text = "Total score: 0";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 153);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(243, 190);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form4Complete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(741, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonPlayAgain);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelMessage);
            Controls.Add(labelTotalScore);
            Controls.Add(labelCurrentScore);
            Controls.Add(labelHeader);
            Name = "Form4Complete";
            Text = "Form4Complete";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private PictureBox pictureBox1;
        private Button buttonPlayAgain;
        private Button buttonExit;
        private TextBox textBox1;
        private Label labelCurrentScore;
        private Label labelMessage;
        private Label labelTotalScore;
        private PictureBox pictureBox2;
    }
}