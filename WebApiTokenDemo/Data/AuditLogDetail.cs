using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class AuditLogDetail
    {
        public long Id { get; set; }
        [Required]
        [StringLength(256)]
        public string PropertyName { get; set; }
        public string OriginalValue { get; set; }
        public string NewValue { get; set; }
        public long AuditLogId { get; set; }

        [ForeignKey("AuditLogId")]
        [InverseProperty("AuditLogDetails")]
        public AuditLog AuditLog { get; set; }
    }
}
