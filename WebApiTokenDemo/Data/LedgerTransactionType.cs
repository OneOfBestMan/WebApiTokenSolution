using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerTransactionTypes", Schema = "accounts")]
    public partial class LedgerTransactionType
    {
        public LedgerTransactionType()
        {
            LedgerTransactionTypeValidPayeeLedgerAccountTypes = new HashSet<LedgerTransactionTypeValidPayeeLedgerAccountType>();
            LedgerTransactionTypeValidRecipientLedgerAccountTypes = new HashSet<LedgerTransactionTypeValidRecipientLedgerAccountType>();
            LedgerTransactions = new HashSet<LedgerTransaction>();
        }

        public int Id { get; set; }
        public int LedgerTransactionTypeCategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerTransactionTypeCategoryId")]
        [InverseProperty("LedgerTransactionTypes")]
        public LedgerTransactionTypeCategory LedgerTransactionTypeCategory { get; set; }
        [InverseProperty("LedgerTransactionType")]
        public ICollection<LedgerTransactionTypeValidPayeeLedgerAccountType> LedgerTransactionTypeValidPayeeLedgerAccountTypes { get; set; }
        [InverseProperty("LedgerTransactionType")]
        public ICollection<LedgerTransactionTypeValidRecipientLedgerAccountType> LedgerTransactionTypeValidRecipientLedgerAccountTypes { get; set; }
        [InverseProperty("LedgerTransactionType")]
        public ICollection<LedgerTransaction> LedgerTransactions { get; set; }
    }
}
