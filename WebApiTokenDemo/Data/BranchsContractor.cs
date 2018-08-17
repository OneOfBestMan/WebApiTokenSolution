using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class BranchsContractor
    {
        public int BranchId { get; set; }
        public int ContractorId { get; set; }
        public bool CreatedByThisBranch { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("BranchsContractors")]
        public Branch Branch { get; set; }
        [ForeignKey("ContractorId")]
        [InverseProperty("BranchsContractors")]
        public Contractor Contractor { get; set; }
    }
}
