using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class AuditLog
    {
        public AuditLog()
        {
            AuditLogDetails = new HashSet<AuditLogDetail>();
        }

        public long AuditLogId { get; set; }
        public string UserName { get; set; }
        [Column("EventDateUTC")]
        public DateTimeOffset EventDateUtc { get; set; }
        public int EventType { get; set; }
        [Required]
        [StringLength(512)]
        public string TypeFullName { get; set; }
        [Required]
        [StringLength(256)]
        public string RecordId { get; set; }
        [StringLength(50)]
        public string UserId { get; set; }
        [StringLength(50)]
        public string SessionId { get; set; }
        [StringLength(50)]
        public string IpAddress { get; set; }
        [StringLength(50)]
        public string BatchId { get; set; }
        [StringLength(256)]
        public string Action { get; set; }

        [InverseProperty("AuditLog")]
        public ICollection<AuditLogDetail> AuditLogDetails { get; set; }
    }
}
