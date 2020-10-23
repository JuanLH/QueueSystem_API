using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Utils.Enums;

namespace Services.Data
{
    [Table("services")]
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Identifier { get; set; }

        [Required]
        [MaxLength(25)]
        public String Name { get; set; }

        public float DurationTime { get; set; }

        public float AvgDurationTime { get; set; }

        public float Price { get; set; }

        public ServiceTypeEnum ServiceType { get; set; }

        public ServiceGroup ServiceGroup { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }

        


    }
}
