using Services.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Data.Models
{
    [Table("appointment_detail")]
    public class AppointmentsDetail
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public Appointment Appointment { get; set; }
        
        [Required]
        public Service Service { get; set; }
    }
}
