using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("SystemData")]
    public partial class SystemDatum
    {
        [Key]
        [StringLength(500)]
        public string Key { get; set; }
        [Required]
        [StringLength(2000)]
        public string Value { get; set; }
        [Column("CSharpType")]
        [StringLength(50)]
        public string CsharpType { get; set; }
        [Column("CSharpDescr")]
        [StringLength(2000)]
        public string CsharpDescr { get; set; }
    }
}
