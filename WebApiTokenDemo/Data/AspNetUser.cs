using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserRoles = new HashSet<AspNetUserRole>();
        }

        [StringLength(128)]
        public string Id { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }
        public bool InternalUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Column("ExternalUserProfiles_Id")]
        [StringLength(128)]
        public string ExternalUserProfilesId { get; set; }
        [Column("InternalUserProfiles_Id")]
        [StringLength(128)]
        public string InternalUserProfilesId { get; set; }

        [ForeignKey("ExternalUserProfilesId")]
        [InverseProperty("AspNetUsers")]
        public ExternalUserProfile ExternalUserProfiles { get; set; }
        [ForeignKey("InternalUserProfilesId")]
        [InverseProperty("AspNetUsers")]
        public InternalUserProfile InternalUserProfiles { get; set; }
        [InverseProperty("User")]
        public ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        [InverseProperty("User")]
        public ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        [InverseProperty("User")]
        public ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
    }
}
