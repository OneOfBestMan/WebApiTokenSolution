using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerTypes", Schema = "accounts")]
    public partial class LedgerType
    {
        public LedgerType()
        {
            LedgerAccountTypes = new HashSet<LedgerAccountType>();
            LedgerCategories = new HashSet<LedgerCategory>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("LedgerType")]
        public ICollection<LedgerAccountType> LedgerAccountTypes { get; set; }
        [InverseProperty("LedgerType")]
        public ICollection<LedgerCategory> LedgerCategories { get; set; }
    }
}
