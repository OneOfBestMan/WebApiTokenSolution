using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("CompanysSpecialLedgerTypes", Schema = "accounts")]
    public partial class CompanysSpecialLedgerType
    {
        public CompanysSpecialLedgerType()
        {
            CompanysSpecialLedgers = new HashSet<CompanysSpecialLedger>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }

        [InverseProperty("CompanysLedgerType")]
        public ICollection<CompanysSpecialLedger> CompanysSpecialLedgers { get; set; }
    }
}
