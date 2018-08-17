using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PdqAccountsBankDeposits", Schema = "banking")]
    public partial class PdqAccountsBankDeposit
    {
        public int BankDepositId { get; set; }
        public int PdqAccountId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("BankDepositId")]
        [InverseProperty("PdqAccountsBankDeposits")]
        public BankDeposit BankDeposit { get; set; }
        [ForeignKey("PdqAccountId")]
        [InverseProperty("PdqAccountsBankDeposits")]
        public PdqAccount PdqAccount { get; set; }
    }
}
