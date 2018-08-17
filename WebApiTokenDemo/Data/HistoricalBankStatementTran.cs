using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("HistoricalBankStatementTrans", Schema = "temp")]
    public partial class HistoricalBankStatementTran
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Bank { get; set; }
        [Required]
        [StringLength(50)]
        public string AccNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StatementDate { get; set; }
        public int ItemOrder { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(255)]
        public string Detail { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal Balance { get; set; }
    }
}
