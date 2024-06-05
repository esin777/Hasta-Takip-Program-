using Hasta_Takip_Programı.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasta_Takip_Programı.Forms
{
    public partial class FrmPatient : Form
    {
        public FrmPatient()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            GetPatientList();
        }
        void GetPatientList()
        {
            dgPatient.Rows.Clear();
            var patients = db.Patients.ToList();
            foreach (var patient in patients)
            {
                dgPatient.Rows.Add(patient.Id, patient.Name, patient.LastName, patient.Birthday, patient.Gender, patient.Address, patient.Email, patient.PhoneNumber);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPatient.Text == "" || txtName.Text == "" || txtLastName.Text == "" || dtpBirthday.Text == "" || txtGender.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz ve Alanları Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var patientNo = Convert.ToInt32(txtPatient.Text);
            var patient = db.Patients.Where(x => x.Id == patientNo).SingleOrDefault();
            if (patientNo == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            patient.Id = Convert.ToInt32(txtPatient.Text);
            patient.Name = txtName.Text;
            patient.LastName = txtLastName.Text;
            patient.Birthday = dtpBirthday.MaxDate;
            patient.Email = txtEmail.Text;
            patient.PhoneNumber = txtPhoneNumber.Text;
            patient.Address = txtAddress.Text;

            db.Patients.Update(patient);
            db.SaveChanges(); MessageBox.Show("Hasta Kaydı Güncellendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPatientList();
            btnClear.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
                if (txtPatient.Text == "" || txtName.Text == "" || txtLastName.Text == "" || txtGender.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || dtpBirthday.Text == "" || txtPhoneNumber.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (db.Patients.Count(c => c.Name == txtName.Text) > 0)
                {
                    MessageBox.Show("Girilen Hasta Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var patient = new Patient();

                patient.Name = txtName.Text;
                patient.LastName = txtLastName.Text;
                patient.Gender = txtGender.Text;
                patient.PhoneNumber = txtPhoneNumber.Text;
                patient.Email = txtEmail.Text;
                patient.Address = txtAddress.Text;

                db.Patients.Add(patient);
                db.SaveChanges();
                MessageBox.Show("Hasta Kaydı Eklendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetPatientList();
                btnClear.PerformClick();

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
                if (txtPatient.Text == "")
                {
                    MessageBox.Show("Lütfen Bir Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var patient = Convert.ToInt32(txtPatient.Text);
                var patientNo = db.Patients.Where(x => x.Id == patient).SingleOrDefault();
                if (patient == null)
                {
                    MessageBox.Show("Geçerli Bir Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.Patients.Remove(patientNo);
                db.SaveChanges();
                MessageBox.Show("Hasta Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetPatientList();
                btnClear.PerformClick();
            }
        }
    }

