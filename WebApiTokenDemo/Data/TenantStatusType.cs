using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantStatusTypes", Schema = "letting")]
    public partial class TenantStatusType
    {
        public TenantStatusType()
        {
            Tenants = new HashSet<Tenant>();
            TenantsTenancyAgreements = new HashSet<TenantsTenancyAgreement>();
        }

        [Key]
        [StringLength(1)]
        public string Code { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("StatusCodeNavigation")]
        public ICollection<Tenant> Tenants { get; set; }
        [InverseProperty("StatusCodeNavigation")]
        public ICollection<TenantsTenancyAgreement> TenantsTenancyAgreements { get; set; }
    }
}
