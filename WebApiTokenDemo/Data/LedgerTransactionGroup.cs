using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerTransactionGroups", Schema = "accounts")]
    public partial class LedgerTransactionGroup
    {
        public LedgerTransactionGroup()
        {
            ContractorInvoices = new HashSet<ContractorInvoice>();
            LedgerTransactions = new HashSet<LedgerTransaction>();
        }

        public int Id { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? CreditAmt { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? DebitAmt { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Balance { get; set; }
        public int? LedgerTransactionGroupTypeId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerTransactionGroupTypeId")]
        [InverseProperty("LedgerTransactionGroups")]
        public LedgerTransactionGroupType LedgerTransactionGroupType { get; set; }
        [InverseProperty("TransactionItemGroup")]
        public ICollection<ContractorInvoice> ContractorInvoices { get; set; }
        [InverseProperty("LedgerTransactionGroup")]
        public ICollection<LedgerTransaction> LedgerTransactions { get; set; }
    }
}
