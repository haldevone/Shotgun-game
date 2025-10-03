namespace Inlämningsuppgift2
{
    partial class Form1Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Login));
            LabelLogin = new Label();
            button1Login = new Button();
            button2Register = new Button();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelLogin.Location = new Point(277, 42);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(239, 72);
            LabelLogin.TabIndex = 0;
            LabelLogin.Text = "SHOTGUN";
            // 
            // button1Login
            // 
            button1Login.BackColor = Color.SaddleBrown;
            button1Login.FlatAppearance.BorderSize = 0;
            button1Login.FlatStyle = FlatStyle.Flat;
            button1Login.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1Login.ForeColor = Color.White;
            button1Login.Location = new Point(277, 263);
            button1Login.Name = "button1Login";
            button1Login.Size = new Size(94, 29);
            button1Login.TabIndex = 1;
            button1Login.Text = "Login";
            button1Login.UseVisualStyleBackColor = false;
            button1Login.Click += button1Login_Click;
            // 
            // button2Register
            // 
            button2Register.BackColor = Color.SaddleBrown;
            button2Register.FlatAppearance.BorderSize = 0;
            button2Register.FlatStyle = FlatStyle.Flat;
            button2Register.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2Register.ForeColor = Color.White;
            button2Register.Location = new Point(277, 307);
            button2Register.Name = "button2Register";
            button2Register.Size = new Size(94, 29);
            button2Register.TabIndex = 2;
            button2Register.Text = "Register";
            button2Register.UseVisualStyleBackColor = false;
            button2Register.Click += button2Register_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(277, 179);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(228, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(277, 221);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(228, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(442, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 352);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(button2Register);
            Controls.Add(button1Login);
            Controls.Add(LabelLogin);
            Name = "Form1Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label LabelLogin;
        private Button button1Login;
        private Button button2Register;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private PictureBox pictureBox1;
    }
}
