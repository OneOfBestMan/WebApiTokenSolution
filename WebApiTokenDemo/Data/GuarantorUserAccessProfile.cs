using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("GuarantorUserAccessProfiles", Schema = "user")]
    public partial class GuarantorUserAccessProfile
    {
        [Key]
        public int GuarantorId { get; set; }
        [Required]
        [StringLength(128)]
        public string UserAccessProfileId { get; set; }

        [ForeignKey("GuarantorId")]
        [InverseProperty("GuarantorUserAccessProfile")]
        public Guarantor Guarantor { get; set; }
        [ForeignKey("UserAccessProfileId")]
        [InverseProperty("GuarantorUserAccessProfile")]
        public UserAccessProfile UserAccessProfile { get; set; }
    }
}
