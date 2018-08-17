using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorUserAccessProfiles", Schema = "user")]
    public partial class ContractorUserAccessProfile
    {
        [Key]
        public int ContractorId { get; set; }
        [Required]
        [StringLength(128)]
        public string UserAccessProfileId { get; set; }

        [ForeignKey("ContractorId")]
        [InverseProperty("ContractorUserAccessProfile")]
        public Contractor Contractor { get; set; }
        [ForeignKey("UserAccessProfileId")]
        [InverseProperty("ContractorUserAccessProfile")]
        public UserAccessProfile UserAccessProfile { get; set; }
    }
}
