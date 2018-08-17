using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantLedgerTransactions", Schema = "letting")]
    public partial class TenantLedgerTransaction
    {
        public int TenantId { get; set; }
        public int LedgerTransactionId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("TenantLedgerTransactions")]
        public LedgerTransaction LedgerTransaction { get; set; }
        [ForeignKey("TenantId")]
        [InverseProperty("TenantLedgerTransactions")]
        public Tenant Tenant { get; set; }
    }
}
