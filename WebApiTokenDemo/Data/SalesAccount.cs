using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("SalesAccounts", Schema = "accounts")]
    public partial class SalesAccount
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        public int LedgerId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("SalesAccount")]
        public Ledger Ledger { get; set; }
    }
}
