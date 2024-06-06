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
            aggBtn.BackColor = Color.Transparent;
            aggBtn.BackgroundImage = Properties.Resources.naranja;
            aggBtn.BackgroundImageLayout = ImageLayout.Stretch;
            aggBtn.FlatAppearance.BorderSize = 0;
            aggBtn.FlatStyle = FlatStyle.Flat;
            aggBtn.Font = new Font("Segoe UI", 14.25F);
            aggBtn.Image = Properties.Resources.icons8_signing_a_document_50;
            aggBtn.ImageAlign = ContentAlignment.MiddleLeft;
            aggBtn.Location = new Point(38, 635);
            aggBtn.Margin = new Padding(3, 2, 3, 2);
            aggBtn.Name = "aggBtn";
            aggBtn.Size = new Size(183, 64);
            aggBtn.TabIndex = 2;
            aggBtn.Text = "Añadir";
            aggBtn.UseVisualStyleBackColor = false;
            aggBtn.Click += aggBtn_Click;
            // 
            // cerrarBtn
            // 
            cerrarBtn.BackColor = Color.Transparent;
            cerrarBtn.BackgroundImage = Properties.Resources.naranja;
            cerrarBtn.BackgroundImageLayout = ImageLayout.Stretch;
            cerrarBtn.FlatAppearance.BorderSize = 0;
            cerrarBtn.FlatStyle = FlatStyle.Flat;
            cerrarBtn.Font = new Font("Segoe UI", 14.25F);
            cerrarBtn.Image = Properties.Resources.icons8_macos_close_50;
            cerrarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cerrarBtn.Location = new Point(281, 635);
            cerrarBtn.Margin = new Padding(3, 2, 3, 2);
            cerrarBtn.Name = "cerrarBtn";
            cerrarBtn.Size = new Size(175, 64);
            cerrarBtn.TabIndex = 3;
            cerrarBtn.Text = "Cerrar";
            cerrarBtn.UseVisualStyleBackColor = false;
            cerrarBtn.Click += cerrarBtn_Click;
            // 
            // nombreClienteComboBox
            // 
            nombreClienteComboBox.Font = new Font("Segoe UI", 12F);
            nombreClienteComboBox.FormattingEnabled = true;
            nombreClienteComboBox.Location = new Point(195, 346);
            nombreClienteComboBox.Margin = new Padding(3, 2, 3, 2);
            nombreClienteComboBox.Name = "nombreClienteComboBox";
            nombreClienteComboBox.Size = new Size(255, 29);
            nombreClienteComboBox.TabIndex = 4;
            // 
            // servicioComboBox
            // 
            servicioComboBox.Font = new Font("Segoe UI", 12F);
            servicioComboBox.FormattingEnabled = true;
            servicioComboBox.Location = new Point(195, 406);
            servicioComboBox.Margin = new Padding(3, 2, 3, 2);
            servicioComboBox.Name = "servicioComboBox";
            servicioComboBox.Size = new Size(255, 29);
            servicioComboBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(195, 480);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(495, 105);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1290, 660);
            dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(62, 346);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 8;
            label1.Text = "Nombre Cliente: ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(60, 414);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 9;
            label2.Text = "Nombre Servicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(132, 137);
            label3.Name = "label3";
            label3.Size = new Size(277, 45);
            label3.TabIndex = 10;
            label3.Text = "REGISTRAR CITAS:";
            // 
            // RegCitasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1832, 927);
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
            Margin = new Padding(3, 2, 3, 2);
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