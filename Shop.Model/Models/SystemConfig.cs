using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Column(TypeName = "varchar")]
        public string Code { get; set; }
        [Required]
        [MaxLength(150)]
        public string ValueString { get; set; }
        [Required]
        public int ValueInt { get; set; }
    }
}
