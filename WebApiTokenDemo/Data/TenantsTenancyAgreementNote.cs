using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenantsTenancyAgreementNotes", Schema = "letting")]
    public partial class TenantsTenancyAgreementNote
    {
        public int TenancyAgreementId { get; set; }
        public int TenantId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("NoteId")]
        [InverseProperty("TenantsTenancyAgreementNotes")]
        public Note Note { get; set; }
        [ForeignKey("TenancyAgreementId,TenantId")]
        [InverseProperty("TenantsTenancyAgreementNotes")]
        public TenantsTenancyAgreement Tenan { get; set; }
    }
}
