using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Deparment { get; set; }
        [MaxLength(250)]
        public string Skype { get; set; }
        [MaxLength(250)]
        public string Facebook { get; set; }
        [MaxLength(250)]
        public string Mobile { get; set; }
        [MaxLength(250)]
        public string Email { get; set; }
    }
}
