using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data.Models
{
    [Table("business_configuration")]
    public class CompanyConfiguration
    {
        [Key]
        public Company Company { get; set; }

        public int update_password { get; set; }


    }
}
