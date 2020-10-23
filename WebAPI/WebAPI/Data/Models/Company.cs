using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data.Models
{
    [Table("companies")]
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(5)]
        public String Identificator { get; set; }

        [Required]
        [MaxLength(20)]
        public String Name { get; set; }

        [Required]
        [MaxLength(80)]
        public String Slogan { get; set; }

        [Required]
        [MaxLength(250)]
        public String FullAddress { get; set; }

        [MaxLength(45)]
        public String Mall { get; set; }

        public int MallFloor { get; set; }

        [MaxLength(45)]
        public String MallModule { get; set; }

        [MaxLength(45)]
        public String Country { get; set; }

        [MaxLength(45)]
        public String Province { get; set; }

        [MaxLength(45)]
        public String City { get; set; }

        [MaxLength(45)]
        public String Street { get; set; }

        [MaxLength(45)]
        public String Reference { get; set; }

        public DateTime FundationDate { get; set; }











    }
}
