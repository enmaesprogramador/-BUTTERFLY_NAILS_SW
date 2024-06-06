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
            nombreServicio.Location = new Point(84, 275);
            nombreServicio.Margin = new Padding(3, 2, 3, 2);
            nombreServicio.Multiline = true;
            nombreServicio.Name = "nombreServicio";
            nombreServicio.PlaceholderText = "Nombre Servicio";
            nombreServicio.Size = new Size(403, 39);
            nombreServicio.TabIndex = 0;
            // 
            // precioServicio
            // 
            precioServicio.Location = new Point(84, 347);
            precioServicio.Margin = new Padding(3, 2, 3, 2);
            precioServicio.Multiline = true;
            precioServicio.Name = "precioServicio";
            precioServicio.PlaceholderText = "Precio del Servicio";
            precioServicio.Size = new Size(403, 47);
            precioServicio.TabIndex = 2;
            // 
            // aggServiciobtn
            // 
            aggServiciobtn.BackColor = Color.Transparent;
            aggServiciobtn.BackgroundImage = Properties.Resources.naranja;
            aggServiciobtn.BackgroundImageLayout = ImageLayout.Stretch;
            aggServiciobtn.FlatAppearance.BorderSize = 0;
            aggServiciobtn.FlatStyle = FlatStyle.Flat;
            aggServiciobtn.Font = new Font("Segoe UI", 14.25F);
            aggServiciobtn.Image = Properties.Resources.icons8_macos_close_50;
            aggServiciobtn.ImageAlign = ContentAlignment.MiddleLeft;
            aggServiciobtn.Location = new Point(318, 599);
            aggServiciobtn.Margin = new Padding(3, 2, 3, 2);
            aggServiciobtn.Name = "aggServiciobtn";
            aggServiciobtn.Size = new Size(200, 68);
            aggServiciobtn.TabIndex = 3;
            aggServiciobtn.Text = "Cerrar";
            aggServiciobtn.UseVisualStyleBackColor = false;
            aggServiciobtn.Click += aggServiciobtn_Click;
            // 
            // descServicio
            // 
            descServicio.Location = new Point(84, 458);
            descServicio.Margin = new Padding(3, 2, 3, 2);
            descServicio.Name = "descServicio";
            descServicio.Size = new Size(403, 59);
            descServicio.TabIndex = 4;
            descServicio.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.naranja;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F);
            button1.Image = Properties.Resources.icons8_signing_a_document_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(59, 599);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(212, 68);
            button1.TabIndex = 3;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(556, 74);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1226, 685);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 420);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 6;
            label1.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 149);
            label2.Name = "label2";
            label2.Size = new Size(326, 45);
            label2.TabIndex = 7;
            label2.Text = "AGREGAR SERVICIOS:";
            // 
            // AggServicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1832, 927);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(descServicio);
            Controls.Add(button1);
            Controls.Add(aggServiciobtn);
            Controls.Add(precioServicio);
            Controls.Add(nombreServicio);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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