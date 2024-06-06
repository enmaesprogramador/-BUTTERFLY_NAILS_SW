namespace BUTTERFLYNAILSCENTERSw
{
    partial class AggServicioForm
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
            nombreServicio = new TextBox();
            precioServicio = new TextBox();
            aggServiciobtn = new Button();
            descServicio = new RichTextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // nombreServicio
            // 
            nombreServicio.Location = new Point(86, 248);
            nombreServicio.Multiline = true;
            nombreServicio.Name = "nombreServicio";
            nombreServicio.PlaceholderText = "Nombre Servicio";
            nombreServicio.Size = new Size(460, 51);
            nombreServicio.TabIndex = 0;
            // 
            // precioServicio
            // 
            precioServicio.Location = new Point(86, 321);
            precioServicio.Multiline = true;
            precioServicio.Name = "precioServicio";
            precioServicio.PlaceholderText = "Precio del Servicio";
            precioServicio.Size = new Size(460, 61);
            precioServicio.TabIndex = 2;
            // 
            // aggServiciobtn
            // 
            aggServiciobtn.BackColor = Color.HotPink;
            aggServiciobtn.FlatAppearance.BorderSize = 0;
            aggServiciobtn.FlatStyle = FlatStyle.Flat;
            aggServiciobtn.Font = new Font("Segoe UI", 10.8F);
            aggServiciobtn.Image = Properties.Resources.icons8_macos_close_50;
            aggServiciobtn.ImageAlign = ContentAlignment.MiddleLeft;
            aggServiciobtn.Location = new Point(354, 710);
            aggServiciobtn.Name = "aggServiciobtn";
            aggServiciobtn.Size = new Size(229, 68);
            aggServiciobtn.TabIndex = 3;
            aggServiciobtn.Text = "Cerrar";
            aggServiciobtn.UseVisualStyleBackColor = false;
            aggServiciobtn.Click += aggServiciobtn_Click;
            // 
            // descServicio
            // 
            descServicio.Location = new Point(77, 469);
            descServicio.Name = "descServicio";
            descServicio.Size = new Size(469, 77);
            descServicio.TabIndex = 4;
            descServicio.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F);
            button1.Image = Properties.Resources.icons8_signing_a_document_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(55, 710);
            button1.Name = "button1";
            button1.Size = new Size(242, 68);
            button1.TabIndex = 3;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(630, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1176, 608);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 419);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 6;
            label1.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 105);
            label2.Name = "label2";
            label2.Size = new Size(404, 54);
            label2.TabIndex = 7;
            label2.Text = "AGREGAR SERVICIOS:";
            // 
            // AggServicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1842, 908);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(descServicio);
            Controls.Add(button1);
            Controls.Add(aggServiciobtn);
            Controls.Add(precioServicio);
            Controls.Add(nombreServicio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AggServicioForm";
            Text = "AggServicioForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreServicio;
        private TextBox precioServicio;
        private Button aggServiciobtn;
        private RichTextBox descServicio;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
    }
}