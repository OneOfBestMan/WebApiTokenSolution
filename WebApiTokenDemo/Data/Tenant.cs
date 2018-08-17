using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("Tenants", Schema = "letting")]
    public partial class Tenant
    {
        public Tenant()
        {
            AutoTransferPlans = new HashSet<AutoTransferPlan>();
            BankDetails = new HashSet<BankDetail>();
            BranchsTenants = new HashSet<BranchsTenant>();
            MaintenanceJobs = new HashSet<MaintenanceJob>();
            NextOfKins = new HashSet<NextOfKin>();
            Payees = new HashSet<Payee>();
            TempDataTenantPayments = new HashSet<TempDataTenantPayment>();
            TenantCommunications = new HashSet<TenantCommunication>();
            TenantLedgerTransactions = new HashSet<TenantLedgerTransaction>();
            TenantNotes = new HashSet<TenantNote>();
            TenantsTenancyAgreements = new HashSet<TenantsTenancyAgreement>();
        }

        public int Id { get; set; }
        [StringLength(20)]
        public string Alias { get; set; }
        public int TenantTypeId { get; set; }
        [StringLength(10)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Firstname { get; set; }
        [StringLength(50)]
        public string Middlenames { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(1)]
        public string StatusCode { get; set; }
        [StringLength(1)]
        public string Gender { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Dob { get; set; }
        [StringLength(15)]
        public string MobileNo { get; set; }
        public bool? MobileNoConfirmed { get; set; }
        [StringLength(50)]
        public string MobileNo2Name { get; set; }
        [StringLength(15)]
        public string MobileNo2 { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        [StringLength(50)]
        public string Email2Name { get; set; }
        [StringLength(255)]
        public string Email2 { get; set; }
        public int? NationalityId { get; set; }
        public bool? EmailLetters { get; set; }
        public bool? MarketingOptOut { get; set; }
        [StringLength(50)]
        public string NationalInsurance { get; set; }
        public int? OracleTenantId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FirstTenancyDate { get; set; }
        [StringLength(50)]
        public string FirstTenancyRef { get; set; }
        [StringLength(50)]
        public string FirstTenancyLetBy { get; set; }
        [StringLength(2000)]
        public string ConfidentialNotes { get; set; }
        [StringLength(1)]
        public string PayingOwnRent { get; set; }
        public bool? ReceivingStudentLoan { get; set; }
        public bool? ReceivingHousingBenefit { get; set; }
        [StringLength(25)]
        public string StandardPaymentRef { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        [StringLength(50)]
        public string BusinessName { get; set; }
        [StringLength(113)]
        public string ComputedName { get; set; }
        public bool ActiveRecordIndi { get; set; }

        [ForeignKey("StatusCode")]
        [InverseProperty("Tenants")]
        public TenantStatusType StatusCodeNavigation { get; set; }
        [ForeignKey("TenantTypeId")]
        [InverseProperty("Tenants")]
        public TenantType TenantType { get; set; }
        [InverseProperty("Tenant")]
        public TenantUserAccessProfile TenantUserAccessProfile { get; set; }
        [InverseProperty("Tenant")]
        public TenantsMainAccount TenantsMainAccount { get; set; }
        [InverseProperty("Tenant")]
        public ICollection<AutoTransferPlan> AutoTransferPlans { get; set; }
        [InverseProperty("Tenant")]
        public ICollection<BankDetail> BankDetails { get; set; }
        [InverseProperty("Tenant")]
        public ICollection<BranchsTenant> BranchsTenants { get; set; }
        [InverseProperty("ReportedByTenantNavigation")]
        public ICollection<MaintenanceJob> MaintenanceJobs { get; set; }
        [InverseProperty("Tenant")]
        public ICollection<NextOfKin> NextOfKins { get; set; }
        [InverseProperty("Tenant")]
        public ICollection<Payee> Payees { get; set; }
        [InverseProperty("Tenant")]
        public ICollection<TempDataTenantPayment> TempDataTenantPayments { get; set; }
        [InverseProperty("Tenant")]
        public ICollection<TenantCommunication> TenantCommunications { get; set; }
        [InverseProperty("Tenant")]
        public ICollection<TenantLedgerTransaction> TenantLedgerTransactions { get; set; }
        [InverseProperty("Tenant")]
        public ICollection<TenantNote> TenantNotes { get; set; }
        [InverseProperty("Tenant")]
        public ICollection<TenantsTenancyAgreement> TenantsTenancyAgreements { get; set; }
    }
}
