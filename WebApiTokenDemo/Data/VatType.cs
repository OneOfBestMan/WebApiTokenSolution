using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("VatTypes", Schema = "accounts")]
    public partial class VatType
    {
        public VatType()
        {
            VatRates = new HashSet<VatRate>();
        }

        public int Id { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty("VatType")]
        public ICollection<VatRate> VatRates { get; set; }
    }
}
