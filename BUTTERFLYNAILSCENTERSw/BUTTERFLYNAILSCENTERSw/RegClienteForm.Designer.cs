namespace BUTTERFLYNAILSCENTERSw
{
    partial class RegClienteForm
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
            nCliente = new TextBox();
            telCliente = new TextBox();
            dirCliente = new TextBox();
            regButton = new Button();
            closeBtn = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // nCliente
            // 
            nCliente.Location = new Point(113, 342);
            nCliente.Name = "nCliente";
            nCliente.PlaceholderText = "Nombre";
            nCliente.Size = new Size(249, 27);
            nCliente.TabIndex = 0;
            // 
            // telCliente
            // 
            telCliente.Location = new Point(113, 470);
            telCliente.Name = "telCliente";
            telCliente.PlaceholderText = "Telefono";
            telCliente.Size = new Size(249, 27);
            telCliente.TabIndex = 1;
            // 
            // dirCliente
            // 
            dirCliente.Location = new Point(113, 599);
            dirCliente.Name = "dirCliente";
            dirCliente.PlaceholderText = "Direccion";
            dirCliente.Size = new Size(249, 27);
            dirCliente.TabIndex = 2;
            // 
            // regButton
            // 
            regButton.BackColor = Color.HotPink;
            regButton.FlatAppearance.BorderSize = 0;
            regButton.FlatAppearance.MouseOverBackColor = Color.LightPink;
            regButton.FlatStyle = FlatStyle.Flat;
            regButton.Font = new Font("Segoe UI", 10.8F);
            regButton.Image = Properties.Resources.icons8_signing_a_document_50;
            regButton.ImageAlign = ContentAlignment.MiddleLeft;
            regButton.Location = new Point(40, 741);
            regButton.Name = "regButton";
            regButton.Size = new Size(191, 58);
            regButton.TabIndex = 3;
            regButton.Text = "Registrar";
            regButton.UseVisualStyleBackColor = false;
            regButton.Click += regButton_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.HotPink;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatAppearance.MouseOverBackColor = Color.LightPink;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Segoe UI", 10.8F);
            closeBtn.Image = Properties.Resources.icons8_macos_close_50;
            closeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            closeBtn.Location = new Point(261, 741);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(193, 58);
            closeBtn.TabIndex = 4;
            closeBtn.Text = "Cerrar";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(482, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1245, 600);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 146);
            label1.Name = "label1";
            label1.Size = new Size(387, 54);
            label1.TabIndex = 6;
            label1.Text = "REGISTRAR CLIENTE:";
            // 
            // RegClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1824, 861);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(closeBtn);
            Controls.Add(regButton);
            Controls.Add(dirCliente);
            Controls.Add(telCliente);
            Controls.Add(nCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegClienteForm";
            Text = "RegClienteForm";
            Load += RegClienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nCliente;
        private TextBox telCliente;
        private TextBox dirCliente;
        private Button regButton;
        private Button closeBtn;
        private DataGridView dataGridView1;
        private Label label1;
    }
}