using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class AspNetUserRole
    {
        [StringLength(128)]
        public string UserId { get; set; }
        [StringLength(128)]
        public string RoleId { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("AspNetUserRoles")]
        public AspNetRole Role { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("AspNetUserRoles")]
        public AspNetUser User { get; set; }
    }
}
