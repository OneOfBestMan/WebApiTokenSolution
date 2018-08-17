using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("BankDeposits", Schema = "banking")]
    public partial class BankDeposit
    {
        public BankDeposit()
        {
            BankStatementLedgerTransactions = new HashSet<BankStatementLedgerTransaction>();
            OfficeCashStorageAccountsBankDeposits = new HashSet<OfficeCashStorageAccountsBankDeposit>();
            OfficeChequeStorageAccountsBankDeposits = new HashSet<OfficeChequeStorageAccountsBankDeposit>();
            PdqAccountsBankDeposits = new HashSet<PdqAccountsBankDeposit>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        [Required]
        [StringLength(50)]
        public string Descr { get; set; }
        [Column(TypeName = "date")]
        public DateTime DepositedDate { get; set; }
        public int BranchId { get; set; }
        public int BankAccountId { get; set; }
        public int? ReconciledBankTxItemId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BankAccountId")]
        [InverseProperty("BankDeposits")]
        public BankAccount BankAccount { get; set; }
        [ForeignKey("ReconciledBankTxItemId")]
        [InverseProperty("BankDeposits")]
        public BankStatementTransaction ReconciledBankTxItem { get; set; }
        [InverseProperty("BankDeposit")]
        public ICollection<BankStatementLedgerTransaction> BankStatementLedgerTransactions { get; set; }
        [InverseProperty("BankDeposit")]
        public ICollection<OfficeCashStorageAccountsBankDeposit> OfficeCashStorageAccountsBankDeposits { get; set; }
        [InverseProperty("BankDeposit")]
        public ICollection<OfficeChequeStorageAccountsBankDeposit> OfficeChequeStorageAccountsBankDeposits { get; set; }
        [InverseProperty("BankDeposit")]
        public ICollection<PdqAccountsBankDeposit> PdqAccountsBankDeposits { get; set; }
    }
}
