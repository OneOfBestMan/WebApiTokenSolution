using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantsTenancyOutstandingRentAccounts", Schema = "accounts")]
    public partial class TenantsTenancyOutstandingRentAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int TenancyAgreementId { get; set; }
        public int TenantId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public bool AutoDebtCollect { get; set; }
        public byte AutoDebtCollectProcessOrder { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("TenantsTenancyOutstandingRentAccount")]
        public Ledger Ledger { get; set; }
        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("TenantsTenancyOutstandingRentAccount")]
        public TenantsTenancyAgreement Tenan { get; set; }
    }
}
