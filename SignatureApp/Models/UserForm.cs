using SignatureApp.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SignatureApp.Models
{
    public class UserForm
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string Phone { get; set; }

        [Required]
        public string Signature { get; set; }
    }
}

