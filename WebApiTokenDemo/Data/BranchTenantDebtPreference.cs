using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("BranchTenantDebtPreferences", Schema = "accounts")]
    public partial class BranchTenantDebtPreference
    {
        public int BranchId { get; set; }
        public int LedgerAccountTypeId { get; set; }
        public bool Enabled { get; set; }
        public byte ProcessOrder { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("BranchTenantDebtPreferences")]
        public Branch Branch { get; set; }
        [ForeignKey("LedgerAccountTypeId")]
        [InverseProperty("BranchTenantDebtPreferences")]
        public LedgerAccountType LedgerAccountType { get; set; }
    }
}
