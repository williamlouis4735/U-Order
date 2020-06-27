using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("Users")]
    public class UserDO
    {
        [Key] public long Id { get; set; }

        [StringLength(100)] public string UserNumber { get; set; }

        [StringLength(100)] public string UserPassword { get; set; }
        [StringLength(300)] public string Email { get; set; }
        [StringLength(100)] public string Radio { get; set; }
        [StringLength(300)] public string City { get; set; }
        [StringLength(300)] public string Date { get; set; }




    }
}
