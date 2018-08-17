using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("RefCodes", Schema = "admin")]
    public partial class RefCode
    {
        public int DomainId { get; set; }
        [StringLength(255)]
        public string LowValue { get; set; }
        [StringLength(255)]
        public string HighValue { get; set; }
        [StringLength(255)]
        public string Abbreviation { get; set; }
        [StringLength(255)]
        public string Meaning { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("DomainId")]
        [InverseProperty("RefCodes")]
        public RefCodeDomain Domain { get; set; }
    }
}
