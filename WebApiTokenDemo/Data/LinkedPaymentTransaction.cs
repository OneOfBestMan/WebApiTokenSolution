using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LinkedPaymentTransactions", Schema = "accounts")]
    public partial class LinkedPaymentTransaction
    {
        public int ParentTransId { get; set; }
        public int ChildTransId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
    }
}
