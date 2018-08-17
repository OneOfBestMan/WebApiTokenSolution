using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("OfficeChequeStorageAccountsBankDeposits", Schema = "banking")]
    public partial class OfficeChequeStorageAccountsBankDeposit
    {
        public int BankDepositId { get; set; }
        public int OfficeChequeStorageAccountId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BankDepositId")]
        [InverseProperty("OfficeChequeStorageAccountsBankDeposits")]
        public BankDeposit BankDeposit { get; set; }
        [ForeignKey("OfficeChequeStorageAccountId")]
        [InverseProperty("OfficeChequeStorageAccountsBankDeposits")]
        public OfficeChequeStorageAccount OfficeChequeStorageAccount { get; set; }
    }
}
