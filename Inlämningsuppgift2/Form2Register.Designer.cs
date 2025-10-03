namespace Inlämningsuppgift2
{
    partial class Form2Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Register));
            buttonCreate = new Button();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.SaddleBrown;
            buttonCreate.FlatAppearance.BorderSize = 0;
            buttonCreate.FlatStyle = FlatStyle.Flat;
            buttonCreate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCreate.ForeColor = Color.White;
            buttonCreate.Location = new Point(272, 246);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(272, 158);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(220, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(272, 201);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(220, 27);
            textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 45);
            label1.Name = "label1";
            label1.Size = new Size(241, 72);
            label1.TabIndex = 3;
            label1.Text = "New User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(519, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 228);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form2Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 402);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(buttonCreate);
            Name = "Form2Register";
            Text = "Form2Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private Label label1;
        private PictureBox pictureBox1;
    }
}