using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerAccountTypes", Schema = "accounts")]
    public partial class LedgerAccountType
    {
        public LedgerAccountType()
        {
            BranchTenantDebtPreferences = new HashSet<BranchTenantDebtPreference>();
            LedgerTransactionTypeValidPayeeLedgerAccountTypes = new HashSet<LedgerTransactionTypeValidPayeeLedgerAccountType>();
            LedgerTransactionTypeValidRecipientLedgerAccountTypes = new HashSet<LedgerTransactionTypeValidRecipientLedgerAccountType>();
            Ledgers = new HashSet<Ledger>();
        }

        public int Id { get; set; }
        public int LedgerTypeId { get; set; }
        public int DefaultLedgerCategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string Descr { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("DefaultLedgerCategoryId")]
        [InverseProperty("LedgerAccountTypes")]
        public LedgerCategory DefaultLedgerCategory { get; set; }
        [ForeignKey("LedgerTypeId")]
        [InverseProperty("LedgerAccountTypes")]
        public LedgerType LedgerType { get; set; }
        [InverseProperty("LedgerAccountType")]
        public ICollection<BranchTenantDebtPreference> BranchTenantDebtPreferences { get; set; }
        [InverseProperty("LedgerAccountType")]
        public ICollection<LedgerTransactionTypeValidPayeeLedgerAccountType> LedgerTransactionTypeValidPayeeLedgerAccountTypes { get; set; }
        [InverseProperty("LedgerAccountType")]
        public ICollection<LedgerTransactionTypeValidRecipientLedgerAccountType> LedgerTransactionTypeValidRecipientLedgerAccountTypes { get; set; }
        [InverseProperty("LedgerAccountType")]
        public ICollection<Ledger> Ledgers { get; set; }
    }
}
