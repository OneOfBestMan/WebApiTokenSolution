using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantTypes", Schema = "letting")]
    public partial class TenantType
    {
        public TenantType()
        {
            Tenants = new HashSet<Tenant>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("TenantType")]
        public ICollection<Tenant> Tenants { get; set; }
    }
}
