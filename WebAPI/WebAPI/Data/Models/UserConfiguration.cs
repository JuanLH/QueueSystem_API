using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Users.Data;

namespace WebAPI.Data.Models
{
    [Table("user_configuration")]
    public class UserConfiguration
    {
        [Key]
        public User User { get; set; }

        public bool dark_theme { get; set; }

        public int lock_time { get; set; }

        public String language { get; set; }
    }
}
