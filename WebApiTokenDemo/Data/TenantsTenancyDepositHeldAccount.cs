using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantsTenancyDepositHeldAccounts", Schema = "accounts")]
    public partial class TenantsTenancyDepositHeldAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int TenancyAgreementId { get; set; }
        public int TenantId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("TenantsTenancyDepositHeldAccount")]
        public Ledger Ledger { get; set; }
        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("TenantsTenancyDepositHeldAccount")]
        public TenantsTenancyAgreement Tenan { get; set; }
    }
}
