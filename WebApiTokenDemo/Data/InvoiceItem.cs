using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceHeaderId { get; set; }
        public int? StockId { get; set; }
        public int? ServiceId { get; set; }
        public int? Quantity { get; set; }
        [Required]
        [StringLength(255)]
        public string Details { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal UnitPrice { get; set; }
        [Required]
        [StringLength(2)]
        public string VatType { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? VatAmount { get; set; }
        public int LedgerTransactionId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("InvoiceHeaderId")]
        [InverseProperty("InvoiceItems")]
        public InvoiceHeader InvoiceHeader { get; set; }
        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("InvoiceItem")]
        public LedgerTransaction LedgerTransaction { get; set; }
    }
}
