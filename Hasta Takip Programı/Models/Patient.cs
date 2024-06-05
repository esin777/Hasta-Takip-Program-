using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasta_Takip_Programı.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        [StringLength(11)]
        public string Email { get; set; }

    }
}
