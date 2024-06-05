namespace Hasta_Takip_Programı.Forms
{
    partial class FrmDoctor
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
            txtProfession = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label1 = new Label();
            dgDoctor = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgDoctor).BeginInit();
            SuspendLayout();
            // 
            // txtProfession
            // 
            txtProfession.Location = new Point(545, 375);
            txtProfession.Margin = new Padding(3, 4, 3, 4);
            txtProfession.Name = "txtProfession";
            txtProfession.Size = new Size(105, 27);
            txtProfession.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 379);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 52;
            label8.Text = "E-Posta";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(299, 375);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(105, 27);
            txtEmail.TabIndex = 51;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(105, 375);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(105, 27);
            txtPhoneNumber.TabIndex = 50;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(545, 331);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(105, 27);
            txtLastName.TabIndex = 49;
            // 
            // txtName
            // 
            txtName.Location = new Point(299, 329);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(105, 27);
            txtName.TabIndex = 48;
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 331);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(105, 27);
            txtId.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 379);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 46;
            label6.Text = "Telefon No ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 379);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 45;
            label4.Text = "Uzmanlık Alanı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 335);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 44;
            label3.Text = "Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 336);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 43;
            label2.Text = "Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 333);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 42;
            label5.Text = "Doktor No";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(512, 431);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 45);
            btnClear.TabIndex = 41;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(173, 431);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 45);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(367, 431);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 45);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(27, 431);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 45);
            btnSave.TabIndex = 38;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 37;
            label1.Text = "Doktor";
            // 
            // dgDoctor
            // 
            dgDoctor.AllowUserToAddRows = false;
            dgDoctor.AllowUserToDeleteRows = false;
            dgDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDoctor.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgDoctor.Location = new Point(30, 63);
            dgDoctor.Margin = new Padding(3, 4, 3, 4);
            dgDoctor.Name = "dgDoctor";
            dgDoctor.ReadOnly = true;
            dgDoctor.RowHeadersWidth = 51;
            dgDoctor.RowTemplate.Height = 25;
            dgDoctor.Size = new Size(621, 249);
            dgDoctor.TabIndex = 54;
            dgDoctor.CellClick += dgDoctor_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "Doktor No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 108;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "Adı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 61;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column3.HeaderText = "Soyadı";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 83;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.HeaderText = "Telefon No";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 111;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column5.HeaderText = "E-Posta";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 87;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column6.HeaderText = "Uzmanlık Alanı";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 137;
            // 
            // FrmDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(956, 517);
            Controls.Add(dgDoctor);
            Controls.Add(txtProfession);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDoctor";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += FrmDoctor_Load;
            Click += FrmDoctor_Click;
            ((System.ComponentModel.ISupportInitialize)dgDoctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProfession;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtName;
        private TextBox txtId;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Label label1;
        private DataGridView dgDoctor;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}