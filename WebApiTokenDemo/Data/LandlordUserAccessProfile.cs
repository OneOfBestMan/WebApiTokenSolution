using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LandlordUserAccessProfiles", Schema = "user")]
    public partial class LandlordUserAccessProfile
    {
        [Key]
        public int LandlordId { get; set; }
        [Required]
        [StringLength(128)]
        public string UserAccessProfileId { get; set; }

        [ForeignKey("LandlordId")]
        [InverseProperty("LandlordUserAccessProfile")]
        public Landlord Landlord { get; set; }
        [ForeignKey("UserAccessProfileId")]
        [InverseProperty("LandlordUserAccessProfile")]
        public UserAccessProfile UserAccessProfile { get; set; }
    }
}
