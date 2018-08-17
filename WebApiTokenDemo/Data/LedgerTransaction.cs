using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerTransactions", Schema = "accounts")]
    public partial class LedgerTransaction
    {
        public LedgerTransaction()
        {
            ContractorInvoiceItemCostAllocationLedgerTransactions = new HashSet<ContractorInvoiceItemCostAllocationLedgerTransaction>();
            LandlordLedgerTransactions = new HashSet<LandlordLedgerTransaction>();
            LedgerTransactionBatchLinks = new HashSet<LedgerTransactionBatchLink>();
            OracleLedgerTransactions = new HashSet<OracleLedgerTransaction>();
            PropertyLedgerTransactions = new HashSet<PropertyLedgerTransaction>();
            TempDataTenantPayments = new HashSet<TempDataTenantPayment>();
            TenancyAgreementLedgerTransactions = new HashSet<TenancyAgreementLedgerTransaction>();
            TenantLedgerTransactions = new HashSet<TenantLedgerTransaction>();
            TenantsTenancyAgreementLedgerTransactions = new HashSet<TenantsTenancyAgreementLedgerTransaction>();
        }

        public int Id { get; set; }
        public int LedgerTransactionGroupId { get; set; }
        public int BranchId { get; set; }
        public int LedgerTransactionStageId { get; set; }
        public int LedgerTransactionTypeId { get; set; }
        public byte? PaymentTypeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(255)]
        public string Details { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Amount { get; set; }
        public int? CreditLedgerId { get; set; }
        public int? DebitLedgerId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Posted { get; set; }
        public int? AutoTransferPlanId { get; set; }
        public int? ChequeNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PeriodFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PeriodTo { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("AutoTransferPlanId")]
        [InverseProperty("LedgerTransactions")]
        public AutoTransferPlan AutoTransferPlan { get; set; }
        [ForeignKey("BranchId")]
        [InverseProperty("LedgerTransactions")]
        public Branch Branch { get; set; }
        [ForeignKey("CreditLedgerId")]
        [InverseProperty("LedgerTransactionCreditLedgers")]
        public Ledger CreditLedger { get; set; }
        [ForeignKey("DebitLedgerId")]
        [InverseProperty("LedgerTransactionDebitLedgers")]
        public Ledger DebitLedger { get; set; }
        [ForeignKey("LedgerTransactionGroupId")]
        [InverseProperty("LedgerTransactions")]
        public LedgerTransactionGroup LedgerTransactionGroup { get; set; }
        [ForeignKey("LedgerTransactionStageId")]
        [InverseProperty("LedgerTransactions")]
        public LedgerTransactionStage LedgerTransactionStage { get; set; }
        [ForeignKey("LedgerTransactionTypeId")]
        [InverseProperty("LedgerTransactions")]
        public LedgerTransactionType LedgerTransactionType { get; set; }
        [ForeignKey("PaymentTypeId")]
        [InverseProperty("LedgerTransactions")]
        public PaymentType PaymentType { get; set; }
        [InverseProperty("LedgerTransaction")]
        public BankStatementLedgerTransaction BankStatementLedgerTransaction { get; set; }
        [InverseProperty("LedgerTransaction")]
        public InvoiceItem InvoiceItem { get; set; }
        [InverseProperty("LedgerTransaction")]
        public VatLedgerTransaction VatLedgerTransaction { get; set; }
        [InverseProperty("LedgerTransaction")]
        public ICollection<ContractorInvoiceItemCostAllocationLedgerTransaction> ContractorInvoiceItemCostAllocationLedgerTransactions { get; set; }
        [InverseProperty("LedgerTransaction")]
        public ICollection<LandlordLedgerTransaction> LandlordLedgerTransactions { get; set; }
        [InverseProperty("LedgerTransaction")]
        public ICollection<LedgerTransactionBatchLink> LedgerTransactionBatchLinks { get; set; }
        [InverseProperty("LedgerTransaction")]
        public ICollection<OracleLedgerTransaction> OracleLedgerTransactions { get; set; }
        [InverseProperty("LedgerTransaction")]
        public ICollection<PropertyLedgerTransaction> PropertyLedgerTransactions { get; set; }
        [InverseProperty("LedgerTransaction")]
        public ICollection<TempDataTenantPayment> TempDataTenantPayments { get; set; }
        [InverseProperty("LedgerTransaction")]
        public ICollection<TenancyAgreementLedgerTransaction> TenancyAgreementLedgerTransactions { get; set; }
        [InverseProperty("LedgerTransaction")]
        public ICollection<TenantLedgerTransaction> TenantLedgerTransactions { get; set; }
        [InverseProperty("LedgerTransaction")]
        public ICollection<TenantsTenancyAgreementLedgerTransaction> TenantsTenancyAgreementLedgerTransactions { get; set; }
    }
}
