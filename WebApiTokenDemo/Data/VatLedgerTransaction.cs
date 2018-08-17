using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class VatLedgerTransaction
    {
        public int Id { get; set; }
        public int LedgerTransactionId { get; set; }
        [StringLength(50)]
        public string VatPeriod { get; set; }
        public int? InvoiceHeaderId { get; set; }
        public int? PurchaseHeaderId { get; set; }
        public int VatAccountId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("InvoiceHeaderId")]
        [InverseProperty("VatLedgerTransactions")]
        public InvoiceHeader InvoiceHeader { get; set; }
        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("VatLedgerTransaction")]
        public LedgerTransaction LedgerTransaction { get; set; }
        [ForeignKey("VatAccountId")]
        [InverseProperty("VatLedgerTransactions")]
        public VatAccount VatAccount { get; set; }
    }
}
