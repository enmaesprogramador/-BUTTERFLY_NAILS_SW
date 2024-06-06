namespace BUTTERFLYNAILSCENTERSw
{
    partial class RegCitasForm
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
            aggBtn = new Button();
            cerrarBtn = new Button();
            nombreClienteComboBox = new ComboBox();
            servicioComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // aggBtn
            // 
            aggBtn.BackColor = Color.HotPink;
            aggBtn.FlatAppearance.BorderSize = 0;
            aggBtn.FlatStyle = FlatStyle.Flat;
            aggBtn.Font = new Font("Segoe UI", 10.8F);
            aggBtn.Image = Properties.Resources.icons8_signing_a_document_50;
            aggBtn.ImageAlign = ContentAlignment.MiddleLeft;
            aggBtn.Location = new Point(39, 768);
            aggBtn.Name = "aggBtn";
            aggBtn.Size = new Size(195, 67);
            aggBtn.TabIndex = 2;
            aggBtn.Text = "Añadir";
            aggBtn.UseVisualStyleBackColor = false;
            aggBtn.Click += aggBtn_Click;
            // 
            // cerrarBtn
            // 
            cerrarBtn.BackColor = Color.HotPink;
            cerrarBtn.FlatAppearance.BorderSize = 0;
            cerrarBtn.FlatStyle = FlatStyle.Flat;
            cerrarBtn.Font = new Font("Segoe UI", 10.8F);
            cerrarBtn.Image = Properties.Resources.icons8_macos_close_50;
            cerrarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cerrarBtn.Location = new Point(317, 768);
            cerrarBtn.Name = "cerrarBtn";
            cerrarBtn.Size = new Size(186, 67);
            cerrarBtn.TabIndex = 3;
            cerrarBtn.Text = "Cerrar";
            cerrarBtn.UseVisualStyleBackColor = false;
            cerrarBtn.Click += cerrarBtn_Click;
            // 
            // nombreClienteComboBox
            // 
            nombreClienteComboBox.FormattingEnabled = true;
            nombreClienteComboBox.Location = new Point(170, 322);
            nombreClienteComboBox.Name = "nombreClienteComboBox";
            nombreClienteComboBox.Size = new Size(291, 28);
            nombreClienteComboBox.TabIndex = 4;
            // 
            // servicioComboBox
            // 
            servicioComboBox.FormattingEnabled = true;
            servicioComboBox.Location = new Point(166, 408);
            servicioComboBox.Name = "servicioComboBox";
            servicioComboBox.Size = new Size(291, 28);
            servicioComboBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 499);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(549, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1214, 668);
            dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 325);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 8;
            label1.Text = "Nombre Cliente: ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 416);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre Servicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 127);
            label3.Name = "label3";
            label3.Size = new Size(342, 54);
            label3.TabIndex = 10;
            label3.Text = "REGISTRAR CITAS:";
            // 
            // RegCitasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1824, 861);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(servicioComboBox);
            Controls.Add(nombreClienteComboBox);
            Controls.Add(cerrarBtn);
            Controls.Add(aggBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegCitasForm";
            Text = "RegCitasForm";
            Load += RegCitasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button aggBtn;
        private Button cerrarBtn;
        private ComboBox nombreClienteComboBox;
        private ComboBox servicioComboBox;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}