using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("OfficeCashStorageAccountsBankDeposits", Schema = "banking")]
    public partial class OfficeCashStorageAccountsBankDeposit
    {
        public int BankDepositId { get; set; }
        public int OfficeCashStorageAccountId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BankDepositId")]
        [InverseProperty("OfficeCashStorageAccountsBankDeposits")]
        public BankDeposit BankDeposit { get; set; }
        [ForeignKey("OfficeCashStorageAccountId")]
        [InverseProperty("OfficeCashStorageAccountsBankDeposits")]
        public OfficeCashStorageAccount OfficeCashStorageAccount { get; set; }
    }
}
