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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // unTextBox
            // 
            unTextBox.Location = new Point(166, 301);
            unTextBox.Margin = new Padding(3, 2, 3, 2);
            unTextBox.Name = "unTextBox";
            unTextBox.Size = new Size(215, 23);
            unTextBox.TabIndex = 0;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(166, 333);
            passTextBox.Margin = new Padding(3, 2, 3, 2);
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.PlaceholderText = "*";
            passTextBox.Size = new Size(215, 23);
            passTextBox.TabIndex = 1;
            // 
            // logButton
            // 
            logButton.BackColor = Color.Transparent;
            logButton.BackgroundImage = (Image)resources.GetObject("logButton.BackgroundImage");
            logButton.BackgroundImageLayout = ImageLayout.Stretch;
            logButton.FlatAppearance.BorderSize = 0;
            logButton.FlatStyle = FlatStyle.Flat;
            logButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            logButton.ForeColor = Color.Black;
            logButton.Location = new Point(40, 417);
            logButton.Margin = new Padding(3, 2, 3, 2);
            logButton.Name = "logButton";
            logButton.Size = new Size(165, 30);
            logButton.TabIndex = 2;
            logButton.Text = "ENTRAR";
            logButton.UseVisualStyleBackColor = false;
            logButton.Click += logButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(88, 302);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(64, 331);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(248, 417);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(156, 30);
            button1.TabIndex = 5;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.GelMagic;
            pictureBox1.Location = new Point(12, 85);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 491);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 61);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 80);
            panel1.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(461, 552);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logButton);
            Controls.Add(passTextBox);
            Controls.Add(unTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
    }
}
