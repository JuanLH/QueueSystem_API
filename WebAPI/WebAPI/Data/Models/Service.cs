using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data.Models;
using WebAPI.Utils.Enums;

namespace Services.Data
{
    [Table("services")]
    public class Service 
    {

        public void copyService(Service service) {
            //Id Not Set
            this.Identifier = service.Identifier;
            this.Name = service.Name;
            this.DurationTime = service.DurationTime;
            this.AvgDurationTime = service.AvgDurationTime;
            this.Price = service.Price;
            this.ServiceType = service.ServiceType;
            this.ServiceGroup = service.ServiceGroup;
            //CreatedDate Not Set
            this.UpdatedDate = service.UpdatedDate;


        }

        [Key]
        public int Id { get; set; }

        
        [Index(IsUnique = true)]
        [MaxLength(4)]
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

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }


    }
}
