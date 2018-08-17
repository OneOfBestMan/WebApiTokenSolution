using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("AuditTableHistory", Schema = "audit")]
    public partial class AuditTableHistory
    {
        [Key]
        [Column("HistoryID")]
        public long HistoryId { get; set; }
        [StringLength(10)]
        public string TableSchema { get; set; }
        [StringLength(100)]
        public string TableName { get; set; }
        public int? RowsEffected { get; set; }
        [Column(TypeName = "xml")]
        public string AuditValue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
    }
}
