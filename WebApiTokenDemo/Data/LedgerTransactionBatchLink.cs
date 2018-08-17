using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerTransactionBatchLinks", Schema = "accounts")]
    public partial class LedgerTransactionBatchLink
    {
        public int LedgerTransactionId { get; set; }
        public int LedgerTransactionBatchId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("LedgerTransactionBatchLinks")]
        public LedgerTransaction LedgerTransaction { get; set; }
        [ForeignKey("LedgerTransactionBatchId")]
        [InverseProperty("LedgerTransactionBatchLinks")]
        public LedgerTransactionBatch LedgerTransactionBatch { get; set; }
    }
}
