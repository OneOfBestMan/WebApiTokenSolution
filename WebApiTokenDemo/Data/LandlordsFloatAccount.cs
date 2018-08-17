using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LandlordsFloatAccounts", Schema = "accounts")]
    public partial class LandlordsFloatAccount
    {
        [Key]
        public int LedgerId { get; set; }
        public int LandlordId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public short? MinimumAmount { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LandlordId")]
        [InverseProperty("LandlordsFloatAccount")]
        public Landlord Landlord { get; set; }
        [ForeignKey("LedgerId")]
        [InverseProperty("LandlordsFloatAccount")]
        public Ledger Ledger { get; set; }
    }
}
