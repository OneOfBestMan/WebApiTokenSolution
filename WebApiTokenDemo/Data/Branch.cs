using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class Branch
    {
        public Branch()
        {
            BranchTenantDebtPreferences = new HashSet<BranchTenantDebtPreference>();
            BranchsApplicants = new HashSet<BranchsApplicant>();
            BranchsContractors = new HashSet<BranchsContractor>();
            BranchsLandlords = new HashSet<BranchsLandlord>();
            BranchsLedgers = new HashSet<BranchsLedger>();
            BranchsProperties = new HashSet<BranchsProperty>();
            BranchsTenants = new HashSet<BranchsTenant>();
            CompanysSpecialLedgers = new HashSet<CompanysSpecialLedger>();
            LedgerTransactions = new HashSet<LedgerTransaction>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int CompanyId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
        public int? SuspendDebtRecoveyUntilMaxDaysIntoFuture { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? SuspendDebtRecoveryAmountLimitMax { get; set; }

        [ForeignKey("CompanyId")]
        [InverseProperty("Branches")]
        public Company Company { get; set; }
        [InverseProperty("Branch")]
        public ICollection<BranchTenantDebtPreference> BranchTenantDebtPreferences { get; set; }
        [InverseProperty("Branch")]
        public ICollection<BranchsApplicant> BranchsApplicants { get; set; }
        [InverseProperty("Branch")]
        public ICollection<BranchsContractor> BranchsContractors { get; set; }
        [InverseProperty("Branch")]
        public ICollection<BranchsLandlord> BranchsLandlords { get; set; }
        [InverseProperty("Branch")]
        public ICollection<BranchsLedger> BranchsLedgers { get; set; }
        [InverseProperty("Branch")]
        public ICollection<BranchsProperty> BranchsProperties { get; set; }
        [InverseProperty("Branch")]
        public ICollection<BranchsTenant> BranchsTenants { get; set; }
        [InverseProperty("Branch")]
        public ICollection<CompanysSpecialLedger> CompanysSpecialLedgers { get; set; }
        [InverseProperty("Branch")]
        public ICollection<LedgerTransaction> LedgerTransactions { get; set; }
    }
}
