using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantsMainAccounts", Schema = "accounts")]
    public partial class TenantsMainAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int TenantId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("TenantsMainAccount")]
        public LedgerMainAccount Ledger { get; set; }
        [ForeignKey("TenantId")]
        [InverseProperty("TenantsMainAccount")]
        public Tenant Tenant { get; set; }
    }
}
