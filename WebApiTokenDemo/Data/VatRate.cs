using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("VatRates", Schema = "accounts")]
    public partial class VatRate
    {
        public int Id { get; set; }
        public int VatTypeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime From { get; set; }
        [Column(TypeName = "date")]
        public DateTime? To { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Rate { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("VatTypeId")]
        [InverseProperty("VatRates")]
        public VatType VatType { get; set; }
    }
}
