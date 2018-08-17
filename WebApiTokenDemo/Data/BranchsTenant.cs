using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class BranchsTenant
    {
        public int BranchId { get; set; }
        public int TenantId { get; set; }
        public bool CreatedByThisBranch { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("BranchsTenants")]
        public Branch Branch { get; set; }
        [ForeignKey("TenantId")]
        [InverseProperty("BranchsTenants")]
        public Tenant Tenant { get; set; }
    }
}
