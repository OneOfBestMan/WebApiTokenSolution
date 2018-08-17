using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenancyAgreementLedgerTransactions", Schema = "letting")]
    public partial class TenancyAgreementLedgerTransaction
    {
        public int TenancyAgreementId { get; set; }
        public int LedgerTransactionId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("TenancyAgreementLedgerTransactions")]
        public LedgerTransaction LedgerTransaction { get; set; }
        [ForeignKey("TenancyAgreementId")]
        [InverseProperty("TenancyAgreementLedgerTransactions")]
        public TenancyAgreement TenancyAgreement { get; set; }
    }
}
