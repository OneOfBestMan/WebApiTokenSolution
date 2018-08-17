using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantsTenancyOutstandingGeneralAccounts", Schema = "accounts")]
    public partial class TenantsTenancyOutstandingGeneralAccount
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
        [InverseProperty("TenantsTenancyOutstandingGeneralAccount")]
        public Ledger Ledger { get; set; }
        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("TenantsTenancyOutstandingGeneralAccount")]
        public TenantsTenancyAgreement Tenan { get; set; }
    }
}
