using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class TempEndOfTenancyCharge
    {
        public int Id { get; set; }
        public int TenancyAgreementId { get; set; }
        public int? TenantId { get; set; }
        [Required]
        [StringLength(255)]
        public string Category { get; set; }
        [Required]
        [StringLength(1000)]
        public string Details { get; set; }
        public decimal Amount { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("TempEndOfTenancyCharges")]
        public TenantsTenancyAgreement Tenan { get; set; }
        [ForeignKey("TenancyAgreementId")]
        [InverseProperty("TempEndOfTenancyCharges")]
        public TenancyAgreement TenancyAgreement { get; set; }
    }
}
