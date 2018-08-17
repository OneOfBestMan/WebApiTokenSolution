using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenancyAgreements", Schema = "letting")]
    public partial class TenancyAgreement
    {
        public TenancyAgreement()
        {
            AutoTransferPlans = new HashSet<AutoTransferPlan>();
            ContractorInvoiceItems = new HashSet<ContractorInvoiceItem>();
            TempEndOfTenancyCharges = new HashSet<TempEndOfTenancyCharge>();
            TenancyAgreementAdditionalTerms = new HashSet<TenancyAgreementAdditionalTerm>();
            TenancyAgreementLedgerTransactions = new HashSet<TenancyAgreementLedgerTransaction>();
            TenancyAgreementNotes = new HashSet<TenancyAgreementNote>();
            TenantsTenancyAgreements = new HashSet<TenantsTenancyAgreement>();
        }

        public int Id { get; set; }
        public int PropertyId { get; set; }
        public bool RoomOnly { get; set; }
        [StringLength(25)]
        public string Ref { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        public int? LeadTenantId { get; set; }
        public byte NoOfTenants { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime FixedTermEndDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal Rent { get; set; }
        public int RentPeriodFrequencyTypeId { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? TotalDeposit { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? CommissionRate { get; set; }
        public int TenancyAgreementStageId { get; set; }
        public bool DepositProtectionRequired { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DepositProtectionRegisteredDate { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? DepositProtectionRegisteredAmount { get; set; }
        public int? DepositProtectionSchemeId { get; set; }
        [StringLength(15)]
        public string DepositProtectionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DepositProtectionDeregisteredDate { get; set; }
        [StringLength(1)]
        public string EndOfTenancyElectricBillAccepted { get; set; }
        [StringLength(1)]
        public string EndOfTenancyGasBillAccepted { get; set; }
        [StringLength(1)]
        public string EndOfTenancyWaterBillAccepted { get; set; }
        [StringLength(1)]
        public string EndOfTenancyLocalPropertyChargeBillAccepted { get; set; }
        [StringLength(50)]
        public string SourcedFrom { get; set; }
        [StringLength(25)]
        public string ExtRef { get; set; }
        public bool? GuarantorRequired { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public int? LandlordsPropertiesId { get; set; }
        public bool ActiveRecordIndi { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal? ExtTotalCost { get; set; }
        public byte? KeyCollectionInstructionId { get; set; }
        public byte? KeyReturnInstructionId { get; set; }
        [Required]
        [StringLength(50)]
        public string PublicId { get; set; }

        [ForeignKey("DepositProtectionSchemeId")]
        [InverseProperty("TenancyAgreements")]
        public TenancyDepositProtectionScheme DepositProtectionScheme { get; set; }
        [ForeignKey("KeyCollectionInstructionId")]
        [InverseProperty("TenancyAgreements")]
        public KeyCollectionInstruction KeyCollectionInstruction { get; set; }
        [ForeignKey("KeyReturnInstructionId")]
        [InverseProperty("TenancyAgreements")]
        public KeyReturnInstruction KeyReturnInstruction { get; set; }
        [ForeignKey("LandlordsPropertiesId")]
        [InverseProperty("TenancyAgreements")]
        public PropertysLandlordHistory LandlordsProperties { get; set; }
        [ForeignKey("PropertyId")]
        [InverseProperty("TenancyAgreements")]
        public Property Property { get; set; }
        [ForeignKey("RentPeriodFrequencyTypeId")]
        [InverseProperty("TenancyAgreements")]
        public PeriodFrequencyType RentPeriodFrequencyType { get; set; }
        [ForeignKey("TenancyAgreementStageId")]
        [InverseProperty("TenancyAgreements")]
        public TenancyAgreementStage TenancyAgreementStage { get; set; }
        [InverseProperty("TenancyAgreement")]
        public TenancyAgreementGeneralAccount TenancyAgreementGeneralAccount { get; set; }
        [InverseProperty("TenancyAgreement")]
        public TenancyAgreementLeadTenant TenancyAgreementLeadTenant { get; set; }
        [InverseProperty("TenancyAgreement")]
        public TenancyAgreementRentCollectedAccount TenancyAgreementRentCollectedAccount { get; set; }
        [InverseProperty("TenancyAgreement")]
        public ICollection<AutoTransferPlan> AutoTransferPlans { get; set; }
        [InverseProperty("TenancyAgreement")]
        public ICollection<ContractorInvoiceItem> ContractorInvoiceItems { get; set; }
        [InverseProperty("TenancyAgreement")]
        public ICollection<TempEndOfTenancyCharge> TempEndOfTenancyCharges { get; set; }
        [InverseProperty("TenancyAgreement")]
        public ICollection<TenancyAgreementAdditionalTerm> TenancyAgreementAdditionalTerms { get; set; }
        [InverseProperty("TenancyAgreement")]
        public ICollection<TenancyAgreementLedgerTransaction> TenancyAgreementLedgerTransactions { get; set; }
        [InverseProperty("TenancyAgreement")]
        public ICollection<TenancyAgreementNote> TenancyAgreementNotes { get; set; }
        [InverseProperty("TenancyAgreement")]
        public ICollection<TenantsTenancyAgreement> TenantsTenancyAgreements { get; set; }
    }
}
