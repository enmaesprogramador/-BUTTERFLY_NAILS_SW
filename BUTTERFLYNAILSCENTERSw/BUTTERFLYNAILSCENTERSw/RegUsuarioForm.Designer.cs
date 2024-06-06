namespace BUTTERFLYNAILSCENTERSw
{
    partial class RegUsuarioForm
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
            nNombreUsuariotb = new TextBox();
            nPasswordtb = new TextBox();
            btnRegistrarUsuario = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nNombreUsuariotb
            // 
            nNombreUsuariotb.Location = new Point(155, 119);
            nNombreUsuariotb.Name = "nNombreUsuariotb";
            nNombreUsuariotb.PlaceholderText = "Nombre Usuario";
            nNombreUsuariotb.Size = new Size(277, 27);
            nNombreUsuariotb.TabIndex = 0;
            // 
            // nPasswordtb
            // 
            nPasswordtb.Location = new Point(155, 194);
            nPasswordtb.Name = "nPasswordtb";
            nPasswordtb.PlaceholderText = "Contraseña";
            nPasswordtb.Size = new Size(277, 27);
            nPasswordtb.TabIndex = 1;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.BackColor = Color.HotPink;
            btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            btnRegistrarUsuario.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btnRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            btnRegistrarUsuario.Font = new Font("Segoe UI", 10.8F);
            btnRegistrarUsuario.Image = Properties.Resources.icons8_signing_a_document_50;
            btnRegistrarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarUsuario.Location = new Point(46, 433);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(184, 52);
            btnRegistrarUsuario.TabIndex = 2;
            btnRegistrarUsuario.Text = "Registrar";
            btnRegistrarUsuario.UseVisualStyleBackColor = false;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.LightPink;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F);
            button1.Image = Properties.Resources.icons8_macos_close_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(303, 433);
            button1.Name = "button1";
            button1.Size = new Size(184, 52);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(754, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(998, 585);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 276);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 6;
            label1.Text = "Rol:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Empleado" });
            comboBox1.Location = new Point(155, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(277, 28);
            comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(101, 117);
            label2.Name = "label2";
            label2.Size = new Size(381, 54);
            label2.TabIndex = 8;
            label2.Text = "AGREGAR USUARIO:";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(nNombreUsuariotb);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(nPasswordtb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegistrarUsuario);
            panel1.Location = new Point(77, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 587);
            panel1.TabIndex = 9;
            // 
            // RegUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1842, 908);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegUsuarioForm";
            Text = "RegUsuarioForm";
            Load += RegUsuarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nNombreUsuariotb;
        private TextBox nPasswordtb;
        private Button btnRegistrarUsuario;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Panel panel1;
    }
}