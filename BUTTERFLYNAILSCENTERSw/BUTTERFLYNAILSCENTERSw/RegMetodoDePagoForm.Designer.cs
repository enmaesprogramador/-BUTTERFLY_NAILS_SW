namespace BUTTERFLYNAILSCENTERSw
{
    partial class RegMetodoDePagoForm
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
            comboBox1 = new ComboBox();
            aggBtn = new Button();
            cerrarBtn = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tarjeta", "Efectivo", "Transferencia", "Cheque", "Bono" });
            comboBox1.Location = new Point(157, 215);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(275, 28);
            comboBox1.TabIndex = 0;
            // 
            // aggBtn
            // 
            aggBtn.BackColor = Color.HotPink;
            aggBtn.FlatAppearance.BorderSize = 0;
            aggBtn.FlatAppearance.MouseOverBackColor = Color.LightPink;
            aggBtn.FlatStyle = FlatStyle.Flat;
            aggBtn.Font = new Font("Segoe UI", 10.8F);
            aggBtn.Image = Properties.Resources.icons8_signing_a_document_50;
            aggBtn.ImageAlign = ContentAlignment.MiddleLeft;
            aggBtn.Location = new Point(36, 344);
            aggBtn.Name = "aggBtn";
            aggBtn.Size = new Size(200, 59);
            aggBtn.TabIndex = 1;
            aggBtn.Text = "Agregar";
            aggBtn.UseVisualStyleBackColor = false;
            aggBtn.Click += aggBtn_Click;
            // 
            // cerrarBtn
            // 
            cerrarBtn.BackColor = Color.HotPink;
            cerrarBtn.FlatAppearance.BorderSize = 0;
            cerrarBtn.FlatAppearance.MouseOverBackColor = Color.LightPink;
            cerrarBtn.FlatStyle = FlatStyle.Flat;
            cerrarBtn.Font = new Font("Segoe UI", 10.8F);
            cerrarBtn.Image = Properties.Resources.icons8_macos_close_50;
            cerrarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cerrarBtn.Location = new Point(312, 344);
            cerrarBtn.Name = "cerrarBtn";
            cerrarBtn.Size = new Size(178, 59);
            cerrarBtn.TabIndex = 2;
            cerrarBtn.Text = "Cerrar";
            cerrarBtn.UseVisualStyleBackColor = false;
            cerrarBtn.Click += cerrarBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(670, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1160, 614);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 218);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 163);
            label2.Name = "label2";
            label2.Size = new Size(550, 54);
            label2.TabIndex = 5;
            label2.Text = "AGREGAR METODO DE PAGO:";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(aggBtn);
            panel1.Controls.Add(cerrarBtn);
            panel1.Location = new Point(42, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(542, 567);
            panel1.TabIndex = 6;
            // 
            // RegMetodoDePagoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1842, 908);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegMetodoDePagoForm";
            Text = "RegMetodoDePagoForm";
            Load += RegMetodoDePagoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button aggBtn;
        private Button cerrarBtn;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}