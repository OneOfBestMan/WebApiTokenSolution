using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("CompanysSpecialLedgers", Schema = "accounts")]
    public partial class CompanysSpecialLedger
    {
        public int Id { get; set; }
        public int CompanysLedgerTypeId { get; set; }
        public int LedgerId { get; set; }
        public int? BranchId { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("CompanysSpecialLedgers")]
        public Branch Branch { get; set; }
        [ForeignKey("CompanysLedgerTypeId")]
        [InverseProperty("CompanysSpecialLedgers")]
        public CompanysSpecialLedgerType CompanysLedgerType { get; set; }
        [ForeignKey("LedgerId")]
        [InverseProperty("CompanysSpecialLedgers")]
        public Ledger Ledger { get; set; }
    }
}
