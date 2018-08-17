using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerTransactionTypeCategories", Schema = "accounts")]
    public partial class LedgerTransactionTypeCategory
    {
        public LedgerTransactionTypeCategory()
        {
            LedgerTransactionTypes = new HashSet<LedgerTransactionType>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("LedgerTransactionTypeCategory")]
        public ICollection<LedgerTransactionType> LedgerTransactionTypes { get; set; }
    }
}
