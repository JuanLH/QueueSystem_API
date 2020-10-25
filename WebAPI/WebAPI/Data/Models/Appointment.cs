using Services.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Users.Data;
using WebAPI.Utils.Enums;

namespace WebAPI.Data.Models
{
    [Table("appointments")]
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public User Client { get; set; }

        public User Employee { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        public DateTime FinishTime { get; set; }//Must be Calculate with the services

        [Required]
        public ICollection<AppointmentsDetail> Detail { get; set; }

        public AppointmentTypeEnum AppointmentType { get; set; }

        [MaxLength(45)]
        public String Note { get; set; }


    }
}
