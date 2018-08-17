using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("UserAccessProfiles", Schema = "user")]
    public partial class UserAccessProfile
    {
        [StringLength(128)]
        public string Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CommencesUtc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TerminatesUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        [Required]
        [StringLength(4)]
        public string Pin { get; set; }

        [InverseProperty("UserAccessProfile")]
        public ContractorUserAccessProfile ContractorUserAccessProfile { get; set; }
        [InverseProperty("UserAccessProfile")]
        public GuarantorUserAccessProfile GuarantorUserAccessProfile { get; set; }
        [InverseProperty("UserAccessProfile")]
        public LandlordUserAccessProfile LandlordUserAccessProfile { get; set; }
        [InverseProperty("UserAccessProfile")]
        public PayeeUserAccessProfile PayeeUserAccessProfile { get; set; }
        [InverseProperty("UserAccessProfile")]
        public TenantUserAccessProfile TenantUserAccessProfile { get; set; }
    }
}
