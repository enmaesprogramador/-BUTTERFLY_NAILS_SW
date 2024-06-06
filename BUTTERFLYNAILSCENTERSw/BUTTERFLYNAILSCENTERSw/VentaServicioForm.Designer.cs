namespace BUTTERFLYNAILSCENTERSw
{
    partial class VentaServicioForm
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
            serviciosComboBox = new ComboBox();
            clientesComboBox = new ComboBox();
            metodosPagoComboBox = new ComboBox();
            citasComboBox = new ComboBox();
            regButton = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // serviciosComboBox
            // 
            serviciosComboBox.FormattingEnabled = true;
            serviciosComboBox.Location = new Point(51, 197);
            serviciosComboBox.Name = "serviciosComboBox";
            serviciosComboBox.Size = new Size(254, 28);
            serviciosComboBox.TabIndex = 0;
            // 
            // clientesComboBox
            // 
            clientesComboBox.FormattingEnabled = true;
            clientesComboBox.Location = new Point(333, 197);
            clientesComboBox.Name = "clientesComboBox";
            clientesComboBox.Size = new Size(254, 28);
            clientesComboBox.TabIndex = 1;
            // 
            // metodosPagoComboBox
            // 
            metodosPagoComboBox.FormattingEnabled = true;
            metodosPagoComboBox.Location = new Point(612, 197);
            metodosPagoComboBox.Name = "metodosPagoComboBox";
            metodosPagoComboBox.Size = new Size(254, 28);
            metodosPagoComboBox.TabIndex = 2;
            // 
            // citasComboBox
            // 
            citasComboBox.FormattingEnabled = true;
            citasComboBox.Location = new Point(883, 197);
            citasComboBox.Name = "citasComboBox";
            citasComboBox.Size = new Size(254, 28);
            citasComboBox.TabIndex = 3;
            citasComboBox.SelectedIndexChanged += citasComboBox_SelectedIndexChanged;
            // 
            // regButton
            // 
            regButton.BackColor = Color.HotPink;
            regButton.FlatAppearance.BorderSize = 0;
            regButton.FlatStyle = FlatStyle.Flat;
            regButton.Font = new Font("Segoe UI", 10.8F);
            regButton.Image = Properties.Resources.icons8_cash_50;
            regButton.ImageAlign = ContentAlignment.MiddleLeft;
            regButton.Location = new Point(55, 263);
            regButton.Name = "regButton";
            regButton.Size = new Size(316, 53);
            regButton.TabIndex = 4;
            regButton.Text = "Pagar";
            regButton.UseVisualStyleBackColor = false;
            regButton.Click += regButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F);
            button1.Image = Properties.Resources.icons8_macos_close_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(449, 263);
            button1.Name = "button1";
            button1.Size = new Size(352, 53);
            button1.TabIndex = 5;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 404);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(769, 396);
            dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 157);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 171);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(612, 170);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(883, 166);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1039, 404);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(745, 396);
            dataGridView2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 371);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 12;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1039, 370);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 13;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(571, 85);
            label7.Name = "label7";
            label7.Size = new Size(421, 54);
            label7.TabIndex = 14;
            label7.Text = "FACTURAR SERVICIOS:";
            // 
            // VentaServicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1842, 908);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(regButton);
            Controls.Add(citasComboBox);
            Controls.Add(metodosPagoComboBox);
            Controls.Add(clientesComboBox);
            Controls.Add(serviciosComboBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentaServicioForm";
            Text = "VentaServicioForm";
            Load += VentaServicioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox serviciosComboBox;
        private ComboBox clientesComboBox;
        private ComboBox metodosPagoComboBox;
        private ComboBox citasComboBox;
        private Button regButton;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView2;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}