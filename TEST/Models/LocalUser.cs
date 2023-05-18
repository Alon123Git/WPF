using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST.Models
{
    public class LocalUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public long phoneNumber { get; set; }
    }
}
