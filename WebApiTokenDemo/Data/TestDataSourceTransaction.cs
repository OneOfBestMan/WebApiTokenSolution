using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TestDataSourceTransactions", Schema = "temp")]
    public partial class TestDataSourceTransaction
    {
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        public bool Skip { get; set; }
        [Required]
        public bool? Pause { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Tenant1Amount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Tenant2Amount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Tenant3Amount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Tenant4Amount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Tenant5Amount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Tenant6Amount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Tenant7Amount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Landlord1Amount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Landlord2Amount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Contractor1Amount { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Contractor2Amount { get; set; }
        [StringLength(1)]
        public string PropertyCode { get; set; }
    }
}
