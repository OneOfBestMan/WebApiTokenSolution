using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("Landlords", Schema = "letting")]
    public partial class Landlord
    {
        public Landlord()
        {
            AutoTransferPlans = new HashSet<AutoTransferPlan>();
            BankDetails = new HashSet<BankDetail>();
            BranchsLandlords = new HashSet<BranchsLandlord>();
            LandlordCommunications = new HashSet<LandlordCommunication>();
            LandlordLedgerTransactions = new HashSet<LandlordLedgerTransaction>();
            LandlordNotes = new HashSet<LandlordNote>();
            LandlordsPropertyHistories = new HashSet<LandlordsPropertyHistory>();
            MaintenanceJobs = new HashSet<MaintenanceJob>();
            MaintenancePreferences = new HashSet<MaintenancePreference>();
            TempDataTenantPayments = new HashSet<TempDataTenantPayment>();
        }

        public int Id { get; set; }
        [StringLength(20)]
        public string Alias { get; set; }
        [StringLength(50)]
        public string BusinessName { get; set; }
        [StringLength(10)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Firstname { get; set; }
        [StringLength(50)]
        public string Middlenames { get; set; }
        [StringLength(50)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Dob { get; set; }
        [StringLength(15)]
        public string MobileNo { get; set; }
        public bool? MobileNoPrivate { get; set; }
        [StringLength(15)]
        public string MobileNo2 { get; set; }
        public bool? MobileNo2Private { get; set; }
        [StringLength(15)]
        public string EmergencyTelNo { get; set; }
        public bool? EmergencyTelNoPrivate { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public int? NationalityId { get; set; }
        public bool? EmailLetters { get; set; }
        public bool? MarketingOptOut { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? DefaultManagementFeeRate { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? DefaultRentGuaranteedFeeRate { get; set; }
        [Column("NRL")]
        public bool Nrl { get; set; }
        [Column("NRLAppliesFrom", TypeName = "datetime")]
        public DateTime? NrlappliesFrom { get; set; }
        [Column("NRLExemptionNumber")]
        [StringLength(15)]
        public string NrlexemptionNumber { get; set; }
        [StringLength(2000)]
        public string ConfidentialNotes { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        [StringLength(113)]
        public string ComputedName { get; set; }
        public bool ActiveRecordIndi { get; set; }

        [ForeignKey("NationalityId")]
        [InverseProperty("Landlords")]
        public Country Nationality { get; set; }
        [InverseProperty("Landlord")]
        public LandlordUserAccessProfile LandlordUserAccessProfile { get; set; }
        [InverseProperty("Landlord")]
        public LandlordsContractorPaymentAccount LandlordsContractorPaymentAccount { get; set; }
        [InverseProperty("Landlord")]
        public LandlordsContractorPendingPaymentAccount LandlordsContractorPendingPaymentAccount { get; set; }
        [InverseProperty("Landlord")]
        public LandlordsFloatAccount LandlordsFloatAccount { get; set; }
        [InverseProperty("Landlord")]
        public LandlordsMainAccount LandlordsMainAccount { get; set; }
        [InverseProperty("Landlord")]
        public ICollection<AutoTransferPlan> AutoTransferPlans { get; set; }
        [InverseProperty("Landlord")]
        public ICollection<BankDetail> BankDetails { get; set; }
        [InverseProperty("Landlord")]
        public ICollection<BranchsLandlord> BranchsLandlords { get; set; }
        [InverseProperty("Landlord")]
        public ICollection<LandlordCommunication> LandlordCommunications { get; set; }
        [InverseProperty("Landlord")]
        public ICollection<LandlordLedgerTransaction> LandlordLedgerTransactions { get; set; }
        [InverseProperty("Landlord")]
        public ICollection<LandlordNote> LandlordNotes { get; set; }
        [InverseProperty("Landlord")]
        public ICollection<LandlordsPropertyHistory> LandlordsPropertyHistories { get; set; }
        [InverseProperty("ReportedByLandlordNavigation")]
        public ICollection<MaintenanceJob> MaintenanceJobs { get; set; }
        [InverseProperty("LandlordNavigation")]
        public ICollection<MaintenancePreference> MaintenancePreferences { get; set; }
        [InverseProperty("Landlord")]
        public ICollection<TempDataTenantPayment> TempDataTenantPayments { get; set; }
    }
}
