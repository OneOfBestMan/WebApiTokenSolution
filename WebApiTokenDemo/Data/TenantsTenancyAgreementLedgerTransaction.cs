using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantsTenancyAgreementLedgerTransactions", Schema = "letting")]
    public partial class TenantsTenancyAgreementLedgerTransaction
    {
        public int TenancyAgreementId { get; set; }
        public int TenantId { get; set; }
        public int LedgerTransactionId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("TenantsTenancyAgreementLedgerTransactions")]
        public LedgerTransaction LedgerTransaction { get; set; }
        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("TenantsTenancyAgreementLedgerTransactions")]
        public TenantsTenancyAgreement Tenan { get; set; }
    }
}
