using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class InternalUserProfile
    {
        public InternalUserProfile()
        {
            //AspNetUsers = new HashSet<AspNetUser>();
        }

        [StringLength(128)]
        public string Id { get; set; }
        public int DeptId { get; set; }
        public int? BranchId { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        //[InverseProperty("InternalUserProfiles")]
        //public ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
