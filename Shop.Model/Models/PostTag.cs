using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]        
        public int PostId { get; set; }
        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string TagId { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
    }
}