using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantsTenancyAgreements", Schema = "letting")]
    public partial class TenantsTenancyAgreement
    {
        public TenantsTenancyAgreement()
        {
            AutoTransferPlans = new HashSet<AutoTransferPlan>();
            Guarantors = new HashSet<Guarantor>();
            RentChargeSchedules = new HashSet<RentChargeSchedule>();
            SpreadsheetDepositReturnFormResponses = new HashSet<SpreadsheetDepositReturnFormResponse>();
            SpreadsheetKeyCollectionFormResponses = new HashSet<SpreadsheetKeyCollectionFormResponse>();
            TempEndOfTenancyCharges = new HashSet<TempEndOfTenancyCharge>();
            TenancyAgreementLeadTenants = new HashSet<TenancyAgreementLeadTenant>();
            TenancyAgreementPayees = new HashSet<TenancyAgreementPayee>();
            TenantsTenancyAgreementLedgerTransactions = new HashSet<TenantsTenancyAgreementLedgerTransaction>();
            TenantsTenancyAgreementNotes = new HashSet<TenantsTenancyAgreementNote>();
        }

        public int TenancyAgreementId { get; set; }
        public int TenantId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? OccupancyFromDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? OccupancyToDate { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? DepositAmount { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? RentAmount { get; set; }
        [StringLength(1)]
        public string SignedAgreement { get; set; }
        [StringLength(1)]
        public string GuarantorApproved { get; set; }
        [StringLength(1)]
        public string StandingOrderApproved { get; set; }
        [StringLength(1)]
        public string RentPayee { get; set; }
        public int? BedroomId { get; set; }
        [StringLength(50)]
        public string SourcedFrom { get; set; }
        [StringLength(50)]
        public string ExtRef { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WelcomePackEmail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WelcomePackSms { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? KeysCollected { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? KeysReturned { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CollectKeysTimeProposed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CollectKeysReminderEmail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CollectKeysReminderSms { get; set; }
        [StringLength(255)]
        public string PostTenancyAddressLine1 { get; set; }
        [StringLength(255)]
        public string PostTenancyAddressLine2 { get; set; }
        [StringLength(255)]
        public string PostTenancyAddressTown { get; set; }
        [StringLength(10)]
        public string PostTenancyAddressPostcode { get; set; }
        [StringLength(50)]
        public string PostTenancyBankAccountName { get; set; }
        [StringLength(6)]
        public string PostTenancyBankAccountSortCode { get; set; }
        [StringLength(15)]
        public string PostTenancyBankAccountNo { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? TempPostTenancyBalance { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? TempPostTenancyDepositHeld { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? TempPostTenancyDepositToReturn { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? TempPostTenancyDepositDeductionPersonal { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? TempPostTenancyDepositDeductionGroupShare { get; set; }
        public bool? GuarantorRequired { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        [Required]
        [StringLength(1)]
        public string StatusCode { get; set; }
        public bool ActiveRecordIndi { get; set; }
        [StringLength(255)]
        public string BedroomLocation { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? ForecastedTotalRentCharge { get; set; }
        [StringLength(50)]
        public string PostTenancyAddressCountry { get; set; }
        [StringLength(50)]
        public string PostTenancyBank { get; set; }
        [StringLength(20)]
        public string PostTenancyBankAccountNameAlias { get; set; }
        public bool? DepositPrescribedInfoGiven { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DepositPrescribedInfoGivenDate { get; set; }
        [StringLength(1)]
        public string DepositPrescribedInfoGivenMethod { get; set; }
        [StringLength(255)]
        public string DepositPrescribedInfoGivenAddress { get; set; }

        [ForeignKey("StatusCode")]
        [InverseProperty("TenantsTenancyAgreements")]
        public TenantStatusType StatusCodeNavigation { get; set; }
        [ForeignKey("TenancyAgreementId")]
        [InverseProperty("TenantsTenancyAgreements")]
        public TenancyAgreement TenancyAgreement { get; set; }
        [ForeignKey("TenantId")]
        [InverseProperty("TenantsTenancyAgreements")]
        public Tenant Tenant { get; set; }
        [InverseProperty("Tenan")]
        public ExtUserTenantCheckOutForm ExtUserTenantCheckOutForm { get; set; }
        [InverseProperty("Tenan")]
        public TenantsTenancyDepositHeldAccount TenantsTenancyDepositHeldAccount { get; set; }
        [InverseProperty("Tenan")]
        public TenantsTenancyGuaranteedRentAccount TenantsTenancyGuaranteedRentAccount { get; set; }
        [InverseProperty("Tenan")]
        public TenantsTenancyOutstandingDepositAccount TenantsTenancyOutstandingDepositAccount { get; set; }
        [InverseProperty("Tenan")]
        public TenantsTenancyOutstandingGeneralAccount TenantsTenancyOutstandingGeneralAccount { get; set; }
        [InverseProperty("Tenan")]
        public TenantsTenancyOutstandingRentAccount TenantsTenancyOutstandingRentAccount { get; set; }
        [InverseProperty("Tenan")]
        public ICollection<AutoTransferPlan> AutoTransferPlans { get; set; }
        [InverseProperty("Tenan")]
        public ICollection<Guarantor> Guarantors { get; set; }
        [InverseProperty("Tenan")]
        public ICollection<RentChargeSchedule> RentChargeSchedules { get; set; }
        [InverseProperty("Tenan")]
        public ICollection<SpreadsheetDepositReturnFormResponse> SpreadsheetDepositReturnFormResponses { get; set; }
        [InverseProperty("Tenan")]
        public ICollection<SpreadsheetKeyCollectionFormResponse> SpreadsheetKeyCollectionFormResponses { get; set; }
        [InverseProperty("Tenan")]
        public ICollection<TempEndOfTenancyCharge> TempEndOfTenancyCharges { get; set; }
        [InverseProperty("Tenan")]
        public ICollection<TenancyAgreementLeadTenant> TenancyAgreementLeadTenants { get; set; }
        [InverseProperty("Tenan")]
        public ICollection<TenancyAgreementPayee> TenancyAgreementPayees { get; set; }
        [InverseProperty("Tenan")]
        public ICollection<TenantsTenancyAgreementLedgerTransaction> TenantsTenancyAgreementLedgerTransactions { get; set; }
        [InverseProperty("Tenan")]
        public ICollection<TenantsTenancyAgreementNote> TenantsTenancyAgreementNotes { get; set; }
    }
}
