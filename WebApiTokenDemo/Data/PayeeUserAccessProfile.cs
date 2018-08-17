using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PayeeUserAccessProfiles", Schema = "user")]
    public partial class PayeeUserAccessProfile
    {
        [Key]
        public int PayeeId { get; set; }
        [Required]
        [StringLength(128)]
        public string UserAccessProfileId { get; set; }

        [ForeignKey("PayeeId")]
        [InverseProperty("PayeeUserAccessProfile")]
        public Payee Payee { get; set; }
        [ForeignKey("UserAccessProfileId")]
        [InverseProperty("PayeeUserAccessProfile")]
        public UserAccessProfile UserAccessProfile { get; set; }
    }
}
