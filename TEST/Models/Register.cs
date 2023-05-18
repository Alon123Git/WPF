using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
    }
}
