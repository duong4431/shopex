using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public DateTime? CreatedDate { get;set; }
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string CreatedBy { get;set; }
        public DateTime? UpdateDate { get;set; }
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string UpdateBy { get;set; }        

        public bool Status { get; set; }
    }
}
