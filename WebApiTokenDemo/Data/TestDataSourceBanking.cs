using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TestDataSourceBanking", Schema = "temp")]
    public partial class TestDataSourceBanking
    {
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? ProcessOrder { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        public bool Skip { get; set; }
        [Required]
        public bool? Pause { get; set; }
        [StringLength(2)]
        public string BankDepositId { get; set; }
        [StringLength(255)]
        public string LedgerTransactions { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Amount { get; set; }
    }
}
