using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(100)]
        public string CustomerAddress { get; set; }
        [Required]
        [MaxLength(150)]
        public string CustomerEmail { get; set; }
        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(50)]
        public string CustomerMobile { get; set; }
        [Required]
        [MaxLength(300)]
        public string CustomerMessage { get; set; }
        public DateTime CreateDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string CreateBy { get; set; }
        [Required]
        [MaxLength(100)]
        public string PaymentMethod { get; set; }
        [Required]
        [MaxLength(100)]
        public string PaymentStatus { get; set; }
        public bool? Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
