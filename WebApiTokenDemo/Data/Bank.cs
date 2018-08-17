using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("Banks", Schema = "banking")]
    public partial class Bank
    {
        public Bank()
        {
            BankAccounts = new HashSet<BankAccount>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Bank")]
        public ICollection<BankAccount> BankAccounts { get; set; }
    }
}
