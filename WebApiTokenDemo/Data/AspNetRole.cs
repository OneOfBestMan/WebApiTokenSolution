using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class AspNetRole
    {
        public AspNetRole()
        {
            AspNetUserRoles = new HashSet<AspNetUserRole>();
        }

        [StringLength(128)]
        public string Id { get; set; }
        [Required]
        [StringLength(256)]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

        [InverseProperty("Role")]
        public ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
    }
}
