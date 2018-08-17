using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("OfficeChequeStorageAccounts", Schema = "accounts")]
    public partial class OfficeChequeStorageAccount
    {
        public OfficeChequeStorageAccount()
        {
            OfficeChequeStorageAccountsBankDeposits = new HashSet<OfficeChequeStorageAccountsBankDeposit>();
        }

        [Key]
        public int LedgerId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("OfficeChequeStorageAccount")]
        public Ledger Ledger { get; set; }
        [InverseProperty("OfficeChequeStorageAccount")]
        public ICollection<OfficeChequeStorageAccountsBankDeposit> OfficeChequeStorageAccountsBankDeposits { get; set; }
    }
}
