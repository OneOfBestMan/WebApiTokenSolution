using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenancyAgreementLeadTenants", Schema = "letting")]
    public partial class TenancyAgreementLeadTenant
    {
        [Key]
        public int TenancyAgreementId { get; set; }
        public int TenantId { get; set; }
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("TenancyAgreementLeadTenants")]
        public TenantsTenancyAgreement Tenan { get; set; }
        [ForeignKey("TenancyAgreementId")]
        [InverseProperty("TenancyAgreementLeadTenant")]
        public TenancyAgreement TenancyAgreement { get; set; }
    }
}
