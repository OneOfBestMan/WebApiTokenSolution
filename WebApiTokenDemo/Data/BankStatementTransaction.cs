using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("BankStatementTransactions", Schema = "banking")]
    public partial class BankStatementTransaction
    {
        public BankStatementTransaction()
        {
            BankDeposits = new HashSet<BankDeposit>();
            BankStatementLedgerTransactions = new HashSet<BankStatementLedgerTransaction>();
        }

        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public int? SequenceId { get; set; }
        public int UploadedBankTransactionFileId { get; set; }
        public int RowWithinFile { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(255)]
        public string Details { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Amt { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Balance { get; set; }
        [StringLength(3)]
        public string Currency { get; set; }
        [Required]
        [StringLength(50)]
        public string MatchStatus { get; set; }
        [StringLength(1)]
        public string MatchedBy { get; set; }
        public int? BankPaymentReferenceIdMatch { get; set; }
        public int? LedgerIdMatch { get; set; }
        public byte? PaymentTypeId { get; set; }
        public int? ChequeNo { get; set; }
        public int StatusId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BankAccountId")]
        [InverseProperty("BankStatementTransactions")]
        public BankAccount BankAccount { get; set; }
        [ForeignKey("BankPaymentReferenceIdMatch")]
        [InverseProperty("BankStatementTransactions")]
        public BankPaymentReference BankPaymentReferenceIdMatchNavigation { get; set; }
        [ForeignKey("LedgerIdMatch")]
        [InverseProperty("BankStatementTransactions")]
        public Ledger LedgerIdMatchNavigation { get; set; }
        [ForeignKey("PaymentTypeId")]
        [InverseProperty("BankStatementTransactions")]
        public PaymentType PaymentType { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("BankStatementTransactions")]
        public BankTransactionStatu Status { get; set; }
        [ForeignKey("UploadedBankTransactionFileId")]
        [InverseProperty("BankStatementTransactions")]
        public UploadedBankStatementFile UploadedBankTransactionFile { get; set; }
        [InverseProperty("ReconciledBankTxItem")]
        public ICollection<BankDeposit> BankDeposits { get; set; }
        [InverseProperty("BankTransaction")]
        public ICollection<BankStatementLedgerTransaction> BankStatementLedgerTransactions { get; set; }
    }
}
