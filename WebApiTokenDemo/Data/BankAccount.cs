using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("BankAccounts", Schema = "banking")]
    public partial class BankAccount
    {
        public BankAccount()
        {
            BankDeposits = new HashSet<BankDeposit>();
            BankPaymentReferences = new HashSet<BankPaymentReference>();
            BankStatementTransactions = new HashSet<BankStatementTransaction>();
            UploadedBankStatementFiles = new HashSet<UploadedBankStatementFile>();
        }

        public int Id { get; set; }
        public int BankId { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        [Required]
        [StringLength(50)]
        public string SortCode { get; set; }
        [Required]
        [StringLength(50)]
        public string AccountNo { get; set; }
        [StringLength(1)]
        public string ChequeBookFacility { get; set; }
        [StringLength(1)]
        public string DebitCardFacility { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Reconciled { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        public int? DefaultCsvFileFormatId { get; set; }
        public int? AccountLedgerId { get; set; }
        public int? BankDepositControlAccountLedgerId { get; set; }
        public int? UnidentifiedBankTxControlAccountLedgerId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public bool IsAllowedToUploadStatement { get; set; }
        public bool IsAllowedToMakePayments { get; set; }

        [ForeignKey("AccountLedgerId")]
        [InverseProperty("BankAccountAccountLedgers")]
        public Ledger AccountLedger { get; set; }
        [ForeignKey("BankId")]
        [InverseProperty("BankAccounts")]
        public Bank Bank { get; set; }
        [ForeignKey("BankDepositControlAccountLedgerId")]
        [InverseProperty("BankAccountBankDepositControlAccountLedgers")]
        public Ledger BankDepositControlAccountLedger { get; set; }
        [ForeignKey("DefaultCsvFileFormatId")]
        [InverseProperty("BankAccounts")]
        public CsvFileFormat DefaultCsvFileFormat { get; set; }
        [ForeignKey("UnidentifiedBankTxControlAccountLedgerId")]
        [InverseProperty("BankAccountUnidentifiedBankTxControlAccountLedgers")]
        public Ledger UnidentifiedBankTxControlAccountLedger { get; set; }
        [InverseProperty("BankAccount")]
        public ICollection<BankDeposit> BankDeposits { get; set; }
        [InverseProperty("BankAccount")]
        public ICollection<BankPaymentReference> BankPaymentReferences { get; set; }
        [InverseProperty("BankAccount")]
        public ICollection<BankStatementTransaction> BankStatementTransactions { get; set; }
        [InverseProperty("BankAccount")]
        public ICollection<UploadedBankStatementFile> UploadedBankStatementFiles { get; set; }
    }
}
