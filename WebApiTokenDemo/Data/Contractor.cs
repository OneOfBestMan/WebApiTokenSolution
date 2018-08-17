using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class Contractor
    {
        public Contractor()
        {
            AutoTransferPlans = new HashSet<AutoTransferPlan>();
            BankDetails = new HashSet<BankDetail>();
            BranchsContractors = new HashSet<BranchsContractor>();
            ContractorCommunications = new HashSet<ContractorCommunication>();
            ContractorInvoices = new HashSet<ContractorInvoice>();
            ContractorNotes = new HashSet<ContractorNote>();
            ContractorsAreas = new HashSet<ContractorsArea>();
            ContractorsPendingPaymentAccounts = new HashSet<ContractorsPendingPaymentAccount>();
            MaintenanceJobContractors = new HashSet<MaintenanceJob>();
            MaintenanceJobReportedByContractorNavigations = new HashSet<MaintenanceJob>();
            TempDataTenantPayments = new HashSet<TempDataTenantPayment>();
        }

        public int Id { get; set; }
        [StringLength(20)]
        public string Alias { get; set; }
        public int ContractorTypeId { get; set; }
        [StringLength(50)]
        public string BusinessName { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? CommissionRate { get; set; }
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
        [StringLength(255)]
        public string Email { get; set; }
        public int? NationalityId { get; set; }
        public bool? EmailLetters { get; set; }
        public bool? MarketingOptOut { get; set; }
        [StringLength(50)]
        public string NationalInsurance { get; set; }
        [StringLength(2000)]
        public string ConfidentialNotes { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public bool ActiveRecordIndi { get; set; }

        [ForeignKey("ContractorTypeId")]
        [InverseProperty("Contractors")]
        public ContractorType ContractorType { get; set; }
        [InverseProperty("Contractor")]
        public ContractorUserAccessProfile ContractorUserAccessProfile { get; set; }
        [InverseProperty("Contractor")]
        public ContractorsMainAccount ContractorsMainAccount { get; set; }
        [InverseProperty("Contractor")]
        public ICollection<AutoTransferPlan> AutoTransferPlans { get; set; }
        [InverseProperty("Contractor")]
        public ICollection<BankDetail> BankDetails { get; set; }
        [InverseProperty("Contractor")]
        public ICollection<BranchsContractor> BranchsContractors { get; set; }
        [InverseProperty("Contractor")]
        public ICollection<ContractorCommunication> ContractorCommunications { get; set; }
        [InverseProperty("Contractor")]
        public ICollection<ContractorInvoice> ContractorInvoices { get; set; }
        [InverseProperty("Contractor")]
        public ICollection<ContractorNote> ContractorNotes { get; set; }
        [InverseProperty("Contractor")]
        public ICollection<ContractorsArea> ContractorsAreas { get; set; }
        [InverseProperty("Contractor")]
        public ICollection<ContractorsPendingPaymentAccount> ContractorsPendingPaymentAccounts { get; set; }
        [InverseProperty("Contractor")]
        public ICollection<MaintenanceJob> MaintenanceJobContractors { get; set; }
        [InverseProperty("ReportedByContractorNavigation")]
        public ICollection<MaintenanceJob> MaintenanceJobReportedByContractorNavigations { get; set; }
        [InverseProperty("Contractor")]
        public ICollection<TempDataTenantPayment> TempDataTenantPayments { get; set; }
    }
}
