namespace BUTTERFLYNAILSCENTERSw
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            unTextBox = new TextBox();
            passTextBox = new TextBox();
            logButton = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // unTextBox
            // 
            unTextBox.Location = new Point(230, 367);
            unTextBox.Name = "unTextBox";
            unTextBox.Size = new Size(245, 27);
            unTextBox.TabIndex = 0;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(230, 409);
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.PlaceholderText = "*";
            passTextBox.Size = new Size(245, 27);
            passTextBox.TabIndex = 1;
            // 
            // logButton
            // 
            logButton.BackColor = Color.HotPink;
            logButton.FlatAppearance.BorderSize = 0;
            logButton.FlatStyle = FlatStyle.Flat;
            logButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            logButton.ForeColor = Color.Black;
            logButton.Location = new Point(60, 485);
            logButton.Name = "logButton";
            logButton.Size = new Size(189, 40);
            logButton.TabIndex = 2;
            logButton.Text = "ENTRAR";
            logButton.UseVisualStyleBackColor = false;
            logButton.Click += logButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(49, 369);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(116, 409);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(297, 485);
            button1.Name = "button1";
            button1.Size = new Size(178, 40);
            button1.TabIndex = 5;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 62);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_MAGIC;
            pictureBox1.Location = new Point(82, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.HotPink;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 573);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 33);
            panel2.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(529, 606);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logButton);
            Controls.Add(passTextBox);
            Controls.Add(unTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox unTextBox;
        private TextBox passTextBox;
        private Button logButton;
        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}
