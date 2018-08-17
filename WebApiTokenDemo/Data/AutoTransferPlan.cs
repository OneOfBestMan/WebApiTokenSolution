using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("AutoTransferPlans", Schema = "accounts")]
    public partial class AutoTransferPlan
    {
        public AutoTransferPlan()
        {
            LedgerTransactions = new HashSet<LedgerTransaction>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Details { get; set; }
        public int AutoTransferPlanTypeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime FirstDate { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LastDate { get; set; }
        public int PeriodFrequencyTypeId { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        public int? CreditLedgerId { get; set; }
        public int? DebitLedgerId { get; set; }
        [Column(TypeName = "date")]
        public DateTime NextDate { get; set; }
        public bool UseRecurringDateForTxDate { get; set; }
        public bool GeneratePeriodDetails { get; set; }
        public int TransactionGenerated { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NextPeriodFromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LastProcessed { get; set; }
        public int? RentChargeScheduleId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? OneOffPeriodFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? OneOffPeriodTo { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public int? TenantId { get; set; }
        public int? LandlordId { get; set; }
        public int? ContractorId { get; set; }
        public int? TenancyAgreementId { get; set; }

        [ForeignKey("AutoTransferPlanTypeId")]
        [InverseProperty("AutoTransferPlans")]
        public AutoTransferPlanType AutoTransferPlanType { get; set; }
        [ForeignKey("ContractorId")]
        [InverseProperty("AutoTransferPlans")]
        public Contractor Contractor { get; set; }
        [ForeignKey("CreditLedgerId")]
        [InverseProperty("AutoTransferPlanCreditLedgers")]
        public Ledger CreditLedger { get; set; }
        [ForeignKey("DebitLedgerId")]
        [InverseProperty("AutoTransferPlanDebitLedgers")]
        public Ledger DebitLedger { get; set; }
        [ForeignKey("LandlordId")]
        [InverseProperty("AutoTransferPlans")]
        public Landlord Landlord { get; set; }
        [ForeignKey("PeriodFrequencyTypeId")]
        [InverseProperty("AutoTransferPlans")]
        public PeriodFrequencyType PeriodFrequencyType { get; set; }
        [ForeignKey("RentChargeScheduleId")]
        [InverseProperty("AutoTransferPlans")]
        public RentChargeSchedule RentChargeSchedule { get; set; }
        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("AutoTransferPlans")]
        public TenantsTenancyAgreement Tenan { get; set; }
        [ForeignKey("TenancyAgreementId")]
        [InverseProperty("AutoTransferPlans")]
        public TenancyAgreement TenancyAgreement { get; set; }
        [ForeignKey("TenantId")]
        [InverseProperty("AutoTransferPlans")]
        public Tenant Tenant { get; set; }
        [InverseProperty("AutoTransferPlan")]
        public ICollection<LedgerTransaction> LedgerTransactions { get; set; }
    }
}
