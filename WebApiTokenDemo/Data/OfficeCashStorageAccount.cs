using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("OfficeCashStorageAccounts", Schema = "accounts")]
    public partial class OfficeCashStorageAccount
    {
        public OfficeCashStorageAccount()
        {
            OfficeCashStorageAccountsBankDeposits = new HashSet<OfficeCashStorageAccountsBankDeposit>();
        }

        [Key]
        public int LedgerId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("OfficeCashStorageAccount")]
        public Ledger Ledger { get; set; }
        [InverseProperty("OfficeCashStorageAccount")]
        public ICollection<OfficeCashStorageAccountsBankDeposit> OfficeCashStorageAccountsBankDeposits { get; set; }
    }
}
