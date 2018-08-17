using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantsTenancyOutstandingDepositAccounts", Schema = "accounts")]
    public partial class TenantsTenancyOutstandingDepositAccount
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
        [InverseProperty("TenantsTenancyOutstandingDepositAccount")]
        public Ledger Ledger { get; set; }
        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("TenantsTenancyOutstandingDepositAccount")]
        public TenantsTenancyAgreement Tenan { get; set; }
    }
}
