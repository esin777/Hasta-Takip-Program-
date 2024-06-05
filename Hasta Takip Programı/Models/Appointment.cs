using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasta_Takip_Programı.Models
{
    public class Appointment
    {
        public int Id{ get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
       
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public string ReasonForVisit { get; set; }

       

    }
}
