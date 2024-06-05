namespace Hasta_Takip_Programı.Forms
{
    partial class FrmAppointment
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
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label8 = new Label();
            txtReasonForVisit = new TextBox();
            txtAppointmentTime = new TextBox();
            txtDoctorId = new TextBox();
            txtPatientId = new TextBox();
            txtId = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgAppointment = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            txtAppointmentDate = new TextBox();
            dgDoctor = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            txtProfession = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dgPatient = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            dtpBirthday = new DateTimePicker();
            label16 = new Label();
            txtAddress = new TextBox();
            txtGender = new TextBox();
            txtPatientNo = new TextBox();
            label17 = new Label();
            label18 = new Label();
            label21 = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgAppointment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPatient).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1131, 432);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 45);
            btnClear.TabIndex = 37;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(953, 432);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 45);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1051, 432);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(71, 45);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(870, 432);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(71, 45);
            btnSave.TabIndex = 34;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1061, 141);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 33;
            label8.Text = "Ziyaret Nedeni";
            // 
            // txtReasonForVisit
            // 
            txtReasonForVisit.Location = new Point(1167, 137);
            txtReasonForVisit.Margin = new Padding(3, 4, 3, 4);
            txtReasonForVisit.Name = "txtReasonForVisit";
            txtReasonForVisit.Size = new Size(105, 27);
            txtReasonForVisit.TabIndex = 32;
            // 
            // txtAppointmentTime
            // 
            txtAppointmentTime.Location = new Point(933, 137);
            txtAppointmentTime.Margin = new Padding(3, 4, 3, 4);
            txtAppointmentTime.Name = "txtAppointmentTime";
            txtAppointmentTime.Size = new Size(105, 27);
            txtAppointmentTime.TabIndex = 31;
            // 
            // txtDoctorId
            // 
            txtDoctorId.Location = new Point(1167, 98);
            txtDoctorId.Margin = new Padding(3, 4, 3, 4);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.Size = new Size(105, 27);
            txtDoctorId.TabIndex = 30;
            // 
            // txtPatientId
            // 
            txtPatientId.Location = new Point(1167, 59);
            txtPatientId.Margin = new Padding(3, 4, 3, 4);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(105, 27);
            txtPatientId.TabIndex = 29;
            // 
            // txtId
            // 
            txtId.Location = new Point(933, 59);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(105, 27);
            txtId.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(40, 10);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 27;
            label7.Text = "Randevu ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(830, 147);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 26;
            label6.Text = "Randevu Saati";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(830, 105);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 25;
            label4.Text = "Randevu Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1086, 102);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 24;
            label3.Text = "Doktor No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1096, 63);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 23;
            label2.Text = "Hasta No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(830, 63);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 22;
            label1.Text = "Randevu No";
            // 
            // dgAppointment
            // 
            dgAppointment.AllowUserToAddRows = false;
            dgAppointment.AllowUserToDeleteRows = false;
            dgAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAppointment.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgAppointment.Location = new Point(4, 46);
            dgAppointment.Margin = new Padding(3, 4, 3, 4);
            dgAppointment.Name = "dgAppointment";
            dgAppointment.ReadOnly = true;
            dgAppointment.RowHeadersWidth = 51;
            dgAppointment.RowTemplate.Height = 25;
            dgAppointment.Size = new Size(801, 157);
            dgAppointment.TabIndex = 21;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "Randevu No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 119;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "Hasta No";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column3.HeaderText = "Doktor No";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 108;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.HeaderText = "Randevu Tarihi";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 134;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column5.HeaderText = "Randevu Saati";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 132;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column6.HeaderText = "Ziyaret Nedeni";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 136;
            // 
            // txtAppointmentDate
            // 
            txtAppointmentDate.Location = new Point(933, 99);
            txtAppointmentDate.Margin = new Padding(3, 4, 3, 4);
            txtAppointmentDate.Name = "txtAppointmentDate";
            txtAppointmentDate.Size = new Size(105, 27);
            txtAppointmentDate.TabIndex = 38;
            // 
            // dgDoctor
            // 
            dgDoctor.AllowUserToAddRows = false;
            dgDoctor.AllowUserToDeleteRows = false;
            dgDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDoctor.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgDoctor.Location = new Point(12, 403);
            dgDoctor.Margin = new Padding(3, 4, 3, 4);
            dgDoctor.Name = "dgDoctor";
            dgDoctor.ReadOnly = true;
            dgDoctor.RowHeadersWidth = 51;
            dgDoctor.RowTemplate.Height = 25;
            dgDoctor.Size = new Size(659, 134);
            dgDoctor.TabIndex = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn1.HeaderText = "Doktor No";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 108;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn2.HeaderText = "Adı";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 61;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn3.HeaderText = "Soyadı";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 83;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn4.HeaderText = "Telefon No";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 111;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn5.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 87;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn6.HeaderText = "Uzmanlık Alanı";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 137;
            // 
            // txtProfession
            // 
            txtProfession.Location = new Point(1167, 215);
            txtProfession.Margin = new Padding(3, 4, 3, 4);
            txtProfession.Name = "txtProfession";
            txtProfession.Size = new Size(105, 27);
            txtProfession.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(873, 320);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 66;
            label5.Text = "E-Posta";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(933, 316);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(105, 27);
            txtEmail.TabIndex = 65;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(933, 281);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(105, 27);
            txtPhoneNumber.TabIndex = 64;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(933, 246);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(105, 27);
            txtLastName.TabIndex = 63;
            // 
            // txtName
            // 
            txtName.Location = new Point(933, 211);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(105, 27);
            txtName.TabIndex = 62;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(855, 285);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 60;
            label9.Text = "Telefon No ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1053, 218);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 59;
            label10.Text = "Uzmanlık Alanı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(878, 250);
            label11.Name = "label11";
            label11.Size = new Size(54, 20);
            label11.TabIndex = 58;
            label11.Text = "Soyadı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(897, 218);
            label12.Name = "label12";
            label12.Size = new Size(32, 20);
            label12.TabIndex = 57;
            label12.Text = "Adı";
            // 
            // dgPatient
            // 
            dgPatient.AllowUserToAddRows = false;
            dgPatient.AllowUserToDeleteRows = false;
            dgPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPatient.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, Column7, Column8 });
            dgPatient.Location = new Point(4, 236);
            dgPatient.Margin = new Padding(3, 4, 3, 4);
            dgPatient.Name = "dgPatient";
            dgPatient.ReadOnly = true;
            dgPatient.RowHeadersWidth = 51;
            dgPatient.RowTemplate.Height = 25;
            dgPatient.Size = new Size(801, 145);
            dgPatient.TabIndex = 68;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn7.HeaderText = "Hasta Kimliği";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 127;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn8.HeaderText = "Ad";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 57;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn9.HeaderText = "Soyadı";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 83;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn10.HeaderText = "Doğum";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 88;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn11.HeaderText = "Cinsiyet";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 89;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn12.HeaderText = "Adres";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 76;
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
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(1044, 357);
            dtpBirthday.Margin = new Padding(3, 4, 3, 4);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(228, 27);
            dtpBirthday.TabIndex = 80;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1065, 294);
            label16.Name = "label16";
            label16.Size = new Size(47, 20);
            label16.TabIndex = 79;
            label16.Text = "Adres";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(1167, 285);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(105, 27);
            txtAddress.TabIndex = 78;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(1167, 322);
            txtGender.Margin = new Padding(3, 4, 3, 4);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(105, 27);
            txtGender.TabIndex = 77;
            // 
            // txtPatientNo
            // 
            txtPatientNo.Location = new Point(1167, 250);
            txtPatientNo.Margin = new Padding(3, 4, 3, 4);
            txtPatientNo.Name = "txtPatientNo";
            txtPatientNo.Size = new Size(105, 27);
            txtPatientNo.TabIndex = 74;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1057, 322);
            label17.Name = "label17";
            label17.Size = new Size(60, 20);
            label17.TabIndex = 73;
            label17.Text = "Cinsiyet";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(961, 361);
            label18.Name = "label18";
            label18.Size = new Size(59, 20);
            label18.TabIndex = 72;
            label18.Text = "Doğum";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(1057, 253);
            label21.Name = "label21";
            label21.Size = new Size(98, 20);
            label21.TabIndex = 69;
            label21.Text = "Hasta Kimliği\r\n";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1230, 432);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 45);
            btnSearch.TabIndex = 87;
            btnSearch.Text = "Gözat";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FrmAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1326, 550);
            Controls.Add(btnSearch);
            Controls.Add(dtpBirthday);
            Controls.Add(label16);
            Controls.Add(txtAddress);
            Controls.Add(txtGender);
            Controls.Add(txtPatientNo);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label21);
            Controls.Add(dgPatient);
            Controls.Add(txtProfession);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(dgDoctor);
            Controls.Add(txtAppointmentDate);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(txtReasonForVisit);
            Controls.Add(txtAppointmentTime);
            Controls.Add(txtDoctorId);
            Controls.Add(txtPatientId);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgAppointment);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAppointment";
            Text = "FrmAppointment";
            WindowState = FormWindowState.Maximized;
            Load += FrmAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dgAppointment).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Label label8;
        private TextBox txtReasonForVisit;
        private TextBox txtAppointmentTime;
        private TextBox txtDoctorId;
        private TextBox txtPatientId;
        private TextBox txtId;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgAppointment;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox txtAppointmentDate;
        private DataGridView dgDoctor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TextBox txtProfession;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private DataGridView dgPatient;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DateTimePicker dtpBirthday;
        private Label label16;
        private TextBox txtAddress;
        private TextBox txtGender;
        private TextBox txtPatientNo;
        private Label label17;
        private Label label18;
        private Label label21;
        private Button btnSearch;
    }
}