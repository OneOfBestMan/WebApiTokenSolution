using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantNotes", Schema = "letting")]
    public partial class TenantNote
    {
        public int TenantId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("NoteId")]
        [InverseProperty("TenantNotes")]
        public Note Note { get; set; }
        [ForeignKey("TenantId")]
        [InverseProperty("TenantNotes")]
        public Tenant Tenant { get; set; }
    }
}
