using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("Ledgers", Schema = "accounts")]
    public partial class Ledger
    {
        public Ledger()
        {
            AutoTransferPlanCreditLedgers = new HashSet<AutoTransferPlan>();
            AutoTransferPlanDebitLedgers = new HashSet<AutoTransferPlan>();
            BankAccountAccountLedgers = new HashSet<BankAccount>();
            BankAccountBankDepositControlAccountLedgers = new HashSet<BankAccount>();
            BankAccountUnidentifiedBankTxControlAccountLedgers = new HashSet<BankAccount>();
            BankPaymentReferences = new HashSet<BankPaymentReference>();
            BankStatementTransactions = new HashSet<BankStatementTransaction>();
            BranchsLedgers = new HashSet<BranchsLedger>();
            CompanysSpecialLedgers = new HashSet<CompanysSpecialLedger>();
            ContractorInvoiceItemCostAllocations = new HashSet<ContractorInvoiceItemCostAllocation>();
            InvoiceHeaders = new HashSet<InvoiceHeader>();
            LedgerNotes = new HashSet<LedgerNote>();
            LedgerTransactionCreditLedgers = new HashSet<LedgerTransaction>();
            LedgerTransactionDebitLedgers = new HashSet<LedgerTransaction>();
        }

        public int Id { get; set; }
        public int LedgerAccountTypeId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        public int LedgerCategoryId { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? BalanceWarningMinimum { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? BalanceWarningMaximum { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Reconcilied { get; set; }
        [StringLength(32)]
        public string AccountId { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? DebitTotalAmount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? CreditTotalAmount { get; set; }
        public int? DebitTotalCount { get; set; }
        public int? CreditTotalCount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? DebitTotalAmountUncleared { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? CreditTotalAmountUncleared { get; set; }
        public int? DebitTotalCountUncleared { get; set; }
        public int? CreditTotalCountUncleared { get; set; }
        public int? OracleId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LatestCreditTransDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LatestDebitTransDate { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public decimal? LedgerBalance { get; set; }
        public bool ActiveRecordIndi { get; set; }
        [Required]
        [StringLength(50)]
        public string PublicId { get; set; }

        [ForeignKey("LedgerAccountTypeId")]
        [InverseProperty("Ledgers")]
        public LedgerAccountType LedgerAccountType { get; set; }
        [ForeignKey("LedgerCategoryId")]
        [InverseProperty("Ledgers")]
        public LedgerCategory LedgerCategory { get; set; }
        [InverseProperty("Ledger")]
        public ContractorDeductionAccount ContractorDeductionAccount { get; set; }
        [InverseProperty("Ledger")]
        public ContractorsPendingPaymentAccount ContractorsPendingPaymentAccount { get; set; }
        [InverseProperty("Ledger")]
        public LandlordsContractorPaymentAccount LandlordsContractorPaymentAccount { get; set; }
        [InverseProperty("Ledger")]
        public LandlordsContractorPendingPaymentAccount LandlordsContractorPendingPaymentAccount { get; set; }
        [InverseProperty("Ledger")]
        public LandlordsFloatAccount LandlordsFloatAccount { get; set; }
        [InverseProperty("Ledger")]
        public LedgerMainAccount LedgerMainAccount { get; set; }
        [InverseProperty("Ledger")]
        public OfficeCashStorageAccount OfficeCashStorageAccount { get; set; }
        [InverseProperty("Ledger")]
        public OfficeChequeStorageAccount OfficeChequeStorageAccount { get; set; }
        [InverseProperty("Ledger")]
        public PdqAccount PdqAccount { get; set; }
        [InverseProperty("Ledger")]
        public PendingPaymentsToPayAccount PendingPaymentsToPayAccount { get; set; }
        [InverseProperty("Ledger")]
        public PendingPaymentsToReceiveAccount PendingPaymentsToReceiveAccount { get; set; }
        [InverseProperty("Ledger")]
        public SalesAccount SalesAccount { get; set; }
        [InverseProperty("Ledger")]
        public TenancyAgreementGeneralAccount TenancyAgreementGeneralAccount { get; set; }
        [InverseProperty("Ledger")]
        public TenancyAgreementRentCollectedAccount TenancyAgreementRentCollectedAccount { get; set; }
        [InverseProperty("Ledger")]
        public TenantsTenancyDepositHeldAccount TenantsTenancyDepositHeldAccount { get; set; }
        [InverseProperty("Ledger")]
        public TenantsTenancyGuaranteedRentAccount TenantsTenancyGuaranteedRentAccount { get; set; }
        [InverseProperty("Ledger")]
        public TenantsTenancyOutstandingDepositAccount TenantsTenancyOutstandingDepositAccount { get; set; }
        [InverseProperty("Ledger")]
        public TenantsTenancyOutstandingGeneralAccount TenantsTenancyOutstandingGeneralAccount { get; set; }
        [InverseProperty("Ledger")]
        public TenantsTenancyOutstandingRentAccount TenantsTenancyOutstandingRentAccount { get; set; }
        [InverseProperty("Ledger")]
        public VatAccount VatAccount { get; set; }
        [InverseProperty("CreditLedger")]
        public ICollection<AutoTransferPlan> AutoTransferPlanCreditLedgers { get; set; }
        [InverseProperty("DebitLedger")]
        public ICollection<AutoTransferPlan> AutoTransferPlanDebitLedgers { get; set; }
        [InverseProperty("AccountLedger")]
        public ICollection<BankAccount> BankAccountAccountLedgers { get; set; }
        [InverseProperty("BankDepositControlAccountLedger")]
        public ICollection<BankAccount> BankAccountBankDepositControlAccountLedgers { get; set; }
        [InverseProperty("UnidentifiedBankTxControlAccountLedger")]
        public ICollection<BankAccount> BankAccountUnidentifiedBankTxControlAccountLedgers { get; set; }
        [InverseProperty("ContraLedger")]
        public ICollection<BankPaymentReference> BankPaymentReferences { get; set; }
        [InverseProperty("LedgerIdMatchNavigation")]
        public ICollection<BankStatementTransaction> BankStatementTransactions { get; set; }
        [InverseProperty("Ledger")]
        public ICollection<BranchsLedger> BranchsLedgers { get; set; }
        [InverseProperty("Ledger")]
        public ICollection<CompanysSpecialLedger> CompanysSpecialLedgers { get; set; }
        [InverseProperty("ContraLedger")]
        public ICollection<ContractorInvoiceItemCostAllocation> ContractorInvoiceItemCostAllocations { get; set; }
        [InverseProperty("Ledger")]
        public ICollection<InvoiceHeader> InvoiceHeaders { get; set; }
        [InverseProperty("Ledger")]
        public ICollection<LedgerNote> LedgerNotes { get; set; }
        [InverseProperty("CreditLedger")]
        public ICollection<LedgerTransaction> LedgerTransactionCreditLedgers { get; set; }
        [InverseProperty("DebitLedger")]
        public ICollection<LedgerTransaction> LedgerTransactionDebitLedgers { get; set; }
    }
}
