using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class ExternalUserProfile
    {
        public ExternalUserProfile()
        {
            //AspNetUsers = new HashSet<AspNetUser>();
        }

        [StringLength(128)]
        public string Id { get; set; }
        public string Type { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        //[InverseProperty("ExternalUserProfiles")]
        //public ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
