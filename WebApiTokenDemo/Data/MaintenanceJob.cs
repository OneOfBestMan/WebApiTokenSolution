using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("MaintenanceJobs", Schema = "property")]
    public partial class MaintenanceJob
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int? ContractorId { get; set; }
        public int? ProjectId { get; set; }
        [Required]
        [StringLength(50)]
        public string Reference { get; set; }
        public int? ReportedByTenant { get; set; }
        public int? ReportedByLandlord { get; set; }
        public int? ReportedByContractor { get; set; }
        [StringLength(50)]
        public string ReportedByOther { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReportedDate { get; set; }
        [Required]
        [StringLength(1)]
        public string StatusCode { get; set; }
        public int TypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        public bool AccessWithoutAppointment { get; set; }
        public int PriorityId { get; set; }
        [StringLength(255)]
        public string Notes { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NextActionDate { get; set; }
        [StringLength(255)]
        public string NextActionComment { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("ContractorId")]
        [InverseProperty("MaintenanceJobContractors")]
        public Contractor Contractor { get; set; }
        [ForeignKey("PriorityId")]
        [InverseProperty("MaintenanceJobs")]
        public MaintenanceJobPriority Priority { get; set; }
        [ForeignKey("ProjectId")]
        [InverseProperty("MaintenanceJobs")]
        public Project Project { get; set; }
        [ForeignKey("PropertyId")]
        [InverseProperty("MaintenanceJobs")]
        public Property Property { get; set; }
        [ForeignKey("ReportedByContractor")]
        [InverseProperty("MaintenanceJobReportedByContractorNavigations")]
        public Contractor ReportedByContractorNavigation { get; set; }
        [ForeignKey("ReportedByLandlord")]
        [InverseProperty("MaintenanceJobs")]
        public Landlord ReportedByLandlordNavigation { get; set; }
        [ForeignKey("ReportedByTenant")]
        [InverseProperty("MaintenanceJobs")]
        public Tenant ReportedByTenantNavigation { get; set; }
        [ForeignKey("StatusCode")]
        [InverseProperty("MaintenanceJobs")]
        public MaintenanceJobStatu StatusCodeNavigation { get; set; }
        [ForeignKey("TypeId")]
        [InverseProperty("MaintenanceJobs")]
        public MaintenanceJobType Type { get; set; }
    }
}
