using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data.Models
{
    [Table("services_groups")]
    public class ServiceGroup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public String Name { get; set; }

        [Required]
        [MaxLength(120)]
        public String Description { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }


    }
}
