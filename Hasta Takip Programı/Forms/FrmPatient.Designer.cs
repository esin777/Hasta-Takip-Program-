namespace Hasta_Takip_Programı.Forms
{
    partial class FrmPatient
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
            label7 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            dtpBirthday = new DateTimePicker();
            label8 = new Label();
            txtAddress = new TextBox();
            txtGender = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            txtPatient = new TextBox();
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
            dgPatient = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            txtPhoneNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgPatient).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 492);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 61;
            label7.Text = "E-Posta";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(439, 481);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(105, 27);
            txtEmail.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(333, 449);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 58;
            label9.Text = "Telefon No ";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(142, 520);
            dtpBirthday.Margin = new Padding(3, 4, 3, 4);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(228, 27);
            dtpBirthday.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(333, 409);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 56;
            label8.Text = "Adres";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(435, 400);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(105, 27);
            txtAddress.TabIndex = 55;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(142, 559);
            txtGender.Margin = new Padding(3, 4, 3, 4);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(105, 27);
            txtGender.TabIndex = 54;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(142, 477);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(105, 27);
            txtLastName.TabIndex = 53;
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 439);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(105, 27);
            txtName.TabIndex = 52;
            // 
            // txtPatient
            // 
            txtPatient.Location = new Point(142, 400);
            txtPatient.Margin = new Padding(3, 4, 3, 4);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(105, 27);
            txtPatient.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 559);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 50;
            label6.Text = "Cinsiyet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 528);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 49;
            label4.Text = "Doğum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 481);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 48;
            label3.Text = "Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 443);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 47;
            label2.Text = "Ad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 403);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 46;
            label5.Text = "Hasta Kimliği\r\n";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(661, 456);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 45);
            btnClear.TabIndex = 45;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(661, 400);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 45);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(568, 456);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 45);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(568, 400);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 45);
            btnSave.TabIndex = 42;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(32, 16);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 41;
            label1.Text = "Hasta";
            // 
            // dgPatient
            // 
            dgPatient.AllowUserToAddRows = false;
            dgPatient.AllowUserToDeleteRows = false;
            dgPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPatient.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgPatient.Location = new Point(3, 52);
            dgPatient.Margin = new Padding(3, 4, 3, 4);
            dgPatient.Name = "dgPatient";
            dgPatient.ReadOnly = true;
            dgPatient.RowHeadersWidth = 51;
            dgPatient.RowTemplate.Height = 25;
            dgPatient.Size = new Size(719, 335);
            dgPatient.TabIndex = 40;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "Hasta Kimliği";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 127;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "Ad";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 57;
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
            Column4.HeaderText = "Doğum";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 88;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column5.HeaderText = "Cinsiyet";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 89;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column6.HeaderText = "Adres";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 76;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column7.HeaderText = "Telefon No";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 111;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column8.HeaderText = "E-Posta";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 87;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(439, 443);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(101, 27);
            txtPhoneNumber.TabIndex = 62;
            // 
            // FrmPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1303, 632);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(dtpBirthday);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(txtGender);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtPatient);
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
            Controls.Add(dgPatient);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPatient";
            Text = "FrmPatient";
            Load += FrmPatient_Load;
            ((System.ComponentModel.ISupportInitialize)dgPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtEmail;
        private Label label9;
        private DateTimePicker dtpBirthday;
        private Label label8;
        private TextBox txtAddress;
        private TextBox txtGender;
        private TextBox txtLastName;
        private TextBox txtName;
        private TextBox txtPatient;
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
        private DataGridView dgPatient;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TextBox txtPhoneNumber;
    }
}