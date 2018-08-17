using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantUserAccessProfiles", Schema = "user")]
    public partial class TenantUserAccessProfile
    {
        [Key]
        public int TenantId { get; set; }
        [Required]
        [StringLength(128)]
        public string UserAccessProfileId { get; set; }

        [ForeignKey("TenantId")]
        [InverseProperty("TenantUserAccessProfile")]
        public Tenant Tenant { get; set; }
        [ForeignKey("UserAccessProfileId")]
        [InverseProperty("TenantUserAccessProfile")]
        public UserAccessProfile UserAccessProfile { get; set; }
    }
}
