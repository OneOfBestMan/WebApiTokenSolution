using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerTransactionTypeValidPayeeLedgerAccountTypes", Schema = "accounts")]
    public partial class LedgerTransactionTypeValidPayeeLedgerAccountType
    {
        public int Id { get; set; }
        public int LedgerTransactionTypeId { get; set; }
        public int LedgerAccountTypeId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerAccountTypeId")]
        [InverseProperty("LedgerTransactionTypeValidPayeeLedgerAccountTypes")]
        public LedgerAccountType LedgerAccountType { get; set; }
        [ForeignKey("LedgerTransactionTypeId")]
        [InverseProperty("LedgerTransactionTypeValidPayeeLedgerAccountTypes")]
        public LedgerTransactionType LedgerTransactionType { get; set; }
    }
}
