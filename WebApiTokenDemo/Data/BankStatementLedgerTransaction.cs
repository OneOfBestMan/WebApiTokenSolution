using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("BankStatementLedgerTransactions", Schema = "banking")]
    public partial class BankStatementLedgerTransaction
    {
        [Key]
        public int LedgerTransactionId { get; set; }
        public int? BankTransactionId { get; set; }
        public int? BankDepositId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public int? BankLedgerTransactionTypeId { get; set; }
        public int? ChequeNo { get; set; }
        public bool IsLedgerTransactionAutoGen { get; set; }

        [ForeignKey("BankDepositId")]
        [InverseProperty("BankStatementLedgerTransactions")]
        public BankDeposit BankDeposit { get; set; }
        [ForeignKey("BankLedgerTransactionTypeId")]
        [InverseProperty("BankStatementLedgerTransactions")]
        public BankLedgerTransactionType BankLedgerTransactionType { get; set; }
        [ForeignKey("BankTransactionId")]
        [InverseProperty("BankStatementLedgerTransactions")]
        public BankStatementTransaction BankTransaction { get; set; }
        [ForeignKey("LedgerTransactionId")]
        [InverseProperty("BankStatementLedgerTransaction")]
        public LedgerTransaction LedgerTransaction { get; set; }
    }
}
