using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerTransactionBatches", Schema = "accounts")]
    public partial class LedgerTransactionBatch
    {
        public LedgerTransactionBatch()
        {
            LedgerTransactionBatchLinks = new HashSet<LedgerTransactionBatchLink>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Type { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("LedgerTransactionBatch")]
        public ICollection<LedgerTransactionBatchLink> LedgerTransactionBatchLinks { get; set; }
    }
}
