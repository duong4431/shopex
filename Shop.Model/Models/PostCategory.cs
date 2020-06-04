using Shop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        public int ParentId { get; set; }
        public int? DisplayOrder { get; set; }
        [MaxLength(200)]
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}