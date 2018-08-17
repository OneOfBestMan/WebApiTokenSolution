using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class BranchsLedger
    {
        public int BranchId { get; set; }
        public int LedgerId { get; set; }
        public bool CreatedByThisBranch { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("BranchsLedgers")]
        public Branch Branch { get; set; }
        [ForeignKey("LedgerId")]
        [InverseProperty("BranchsLedgers")]
        public Ledger Ledger { get; set; }
    }
}
