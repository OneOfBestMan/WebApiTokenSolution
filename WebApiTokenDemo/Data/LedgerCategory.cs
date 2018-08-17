using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerCategories", Schema = "accounts")]
    public partial class LedgerCategory
    {
        public LedgerCategory()
        {
            InverseParent = new HashSet<LedgerCategory>();
            LedgerAccountTypes = new HashSet<LedgerAccountType>();
            Ledgers = new HashSet<Ledger>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        public int LedgerTypeId { get; set; }
        public int? ParentId { get; set; }
        public int? OracleId { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        [StringLength(1)]
        public string AllowSubCategories { get; set; }
        [Required]
        [StringLength(25)]
        public string CreditTxTitle { get; set; }
        [Required]
        [StringLength(25)]
        public string DebitTxTitle { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerTypeId")]
        [InverseProperty("LedgerCategories")]
        public LedgerType LedgerType { get; set; }
        [ForeignKey("ParentId")]
        [InverseProperty("InverseParent")]
        public LedgerCategory Parent { get; set; }
        [InverseProperty("Parent")]
        public ICollection<LedgerCategory> InverseParent { get; set; }
        [InverseProperty("DefaultLedgerCategory")]
        public ICollection<LedgerAccountType> LedgerAccountTypes { get; set; }
        [InverseProperty("LedgerCategory")]
        public ICollection<Ledger> Ledgers { get; set; }
    }
}
