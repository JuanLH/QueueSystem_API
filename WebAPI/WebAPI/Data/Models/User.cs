using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Data.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public String UserName { get; set; }

        [Required]
        [MaxLength(30)]
        public String Password { get; set; }

        [Required]
        public String FirstName { get; set; }

        [Required]
        public String LastName { get; set; }

        public String NickName { get; set; }

        [Required]
        public String IdCard { get; set; }

        [Required]
        public String IdCardType { get; set; } //CED = CEDULA, PAS= PASAPORTE, RNC = RNC

        [Required]
        public DateTime Dob { get; set; } //Date of Birth

        public String Telephone { get; set; }

        [Required]
        public String CellPhone { get; set; }

    }
}
