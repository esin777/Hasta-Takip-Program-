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
using System.Xml.Linq;

namespace Hasta_Takip_Programı.Forms
{
    public partial class FrmAppointment : Form
    {
        public FrmAppointment()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();


        private void FrmAppointment_Load(object sender, EventArgs e)
        {
            GetAppointmentList();
        }
        void GetAppointmentList()
        {
            {
                dgAppointment.Rows.Clear();
                List<Appointment> appointments = db.Appointments.ToList();
                foreach (var appointment in appointments)
                {
                    dgAppointment.Rows.Add(appointments.AppointmentId, appointment.AppointmentDate, appointment.AppointmentTime, appointment.PatientId, appointment.DoctorId, appointment.ReasonForVisit, appointment);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtAppointmentId.Text == "" || txtAppointmentTime.Text == "" || txtPatientId.Text == "" || txtReasonForVisit.Text == "" || txtAppointmentDate.Text == "" || txtDoctorId.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz ve Alanları Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var AppointmentId = Convert.ToInt32(txtAppointmentId.Text);
            var appointment = db.Appointments.Where(x => x.Id == AppointmentId).SingleOrDefault();
            if (appointment == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            appointment.DoctorId = Convert.ToInt32(txtAppointmentId.Text);
            appointment.PatientId = Convert.ToInt32(txtPatientId.Text);
            appointment.AppointmentTime = Convert.ToDateTime(txtAppointmentTime.Text);
            appointment.AppointmentDate = Convert.ToDateTime(txtAppointmentDate.Text);
            appointment.ReasonForVisit = txtReasonForVisit.Text;
            


            db.Appointments.Update(appointment);
            db.SaveChanges(); MessageBox.Show("Randevu Kaydı Güncellendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAppointmentList();
            btnClear.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                if (txtAppointmentId.Text == "" || txtAppointmentDate.Text == "" || txtAppointmentTime.Text == "" || txtReasonForVisit.Text == "" || txtPatientId.Text == "" || txtDoctorId.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (db.Appointments.Count(c => c.Id ==Convert.ToInt32( txtAppointmentId.Text)) > 0)
                {
                    MessageBox.Show("Girilen Randevu Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var appointment = new Appointment();
                
                appointment.PatientId = Convert.ToInt32(txtPatientId.Text);
                appointment.ReasonForVisit = Convert.ToInt32(txtReasonForVisit.Text);
                appointment.AppointmentDate = Convert.ToInt32(txtAppointmentDate.Text);
                appointment.AppointmentTime = Convert.ToInt32 (txtAppointmentTime.Text);
                appointment.DoctorId =  Convert.ToInt32(txtDoctorId .Text);


                db.Appointments.Add(appointment);
                db.SaveChanges();
                MessageBox.Show("Randevu Kaydı Eklendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAppointmentList();
                btnClear.PerformClick();

            }
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
            if (txtAppointmentId.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var appointment = Convert.ToInt32(txtAppointmentId.Text);
            var AppointmentId = db.Appointments.Where(x => x.Id == appointment).SingleOrDefault();
            if (appointment == null)
            {
                MessageBox.Show("Geçerli Bir Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Appointments.Remove(AppointmentId);
            db.SaveChanges();
            MessageBox.Show("Randevu Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAppointmentList();
            btnClear.PerformClick();
        }
    }
}

