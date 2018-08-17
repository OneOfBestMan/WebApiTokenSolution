using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class BranchsProperty
    {
        public int BranchId { get; set; }
        public int PropertyId { get; set; }
        public bool CreatedByThisBranch { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("BranchsProperties")]
        public Branch Branch { get; set; }
        [ForeignKey("PropertyId")]
        [InverseProperty("BranchsProperties")]
        public Property Property { get; set; }
    }
}
