using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Image { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]        
        public string ProContent { get; set; }
        public bool? HomeFlag { get; set; }
        public int ViewCount { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}