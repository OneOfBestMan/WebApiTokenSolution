using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class InvoiceHeader
    {
        public InvoiceHeader()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
            VatLedgerTransactions = new HashSet<VatLedgerTransaction>();
        }

        public int Id { get; set; }
        public int LedgerId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("InvoiceHeaders")]
        public Ledger Ledger { get; set; }
        [InverseProperty("InvoiceHeader")]
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
        [InverseProperty("InvoiceHeader")]
        public ICollection<VatLedgerTransaction> VatLedgerTransactions { get; set; }
    }
}
