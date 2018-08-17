using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerMainAccounts", Schema = "accounts")]
    public partial class LedgerMainAccount
    {
        public LedgerMainAccount()
        {
            ContractorInvoiceItemCostAllocations = new HashSet<ContractorInvoiceItemCostAllocation>();
        }

        [Key]
        public int LedgerId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        [StringLength(18)]
        public string OurPaymentReference { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SuspendDebtRecoveryUntil { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? SuspendDebtRecoveryAmountLimit { get; set; }
        [StringLength(255)]
        public string SuspendDebtRecoveryReason { get; set; }
        [StringLength(1)]
        public string PreferredPaymentMethod { get; set; }
        [StringLength(50)]
        public string Bank { get; set; }
        [StringLength(6)]
        public string SortCode { get; set; }
        [StringLength(50)]
        public string BankAccountName { get; set; }
        [StringLength(10)]
        public string BankAccountNo { get; set; }
        [Column("IBAN")]
        [StringLength(50)]
        public string Iban { get; set; }
        [StringLength(50)]
        public string ChequePayeeName { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("LedgerMainAccount")]
        public Ledger Ledger { get; set; }
        [InverseProperty("LedgerMainAccount")]
        public ContractorDeductionAccount ContractorDeductionAccount { get; set; }
        [InverseProperty("Ledger")]
        public ContractorsMainAccount ContractorsMainAccount { get; set; }
        [InverseProperty("Ledger")]
        public DebtRecoveryOperation DebtRecoveryOperation { get; set; }
        [InverseProperty("Ledger")]
        public LandlordsMainAccount LandlordsMainAccount { get; set; }
        [InverseProperty("LedgerMainAccount")]
        public PendingPaymentsToPayAccount PendingPaymentsToPayAccount { get; set; }
        [InverseProperty("LedgerMainAccount")]
        public PendingPaymentsToReceiveAccount PendingPaymentsToReceiveAccount { get; set; }
        [InverseProperty("Ledger")]
        public TenantsMainAccount TenantsMainAccount { get; set; }
        [InverseProperty("LedgerMainAccount")]
        public ICollection<ContractorInvoiceItemCostAllocation> ContractorInvoiceItemCostAllocations { get; set; }
    }
}
