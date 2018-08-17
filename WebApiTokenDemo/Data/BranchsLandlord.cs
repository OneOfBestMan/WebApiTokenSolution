using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class BranchsLandlord
    {
        public int BranchId { get; set; }
        public int LandlordId { get; set; }
        public bool CreatedByThisBranch { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("BranchsLandlords")]
        public Branch Branch { get; set; }
        [ForeignKey("LandlordId")]
        [InverseProperty("BranchsLandlords")]
        public Landlord Landlord { get; set; }
    }
}
