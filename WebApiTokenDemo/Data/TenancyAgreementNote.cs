using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("TenancyAgreementNotes", Schema = "letting")]
    public partial class TenancyAgreementNote
    {
        public int TenancyAgreementId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("NoteId")]
        [InverseProperty("TenancyAgreementNotes")]
        public Note Note { get; set; }
        [ForeignKey("TenancyAgreementId")]
        [InverseProperty("TenancyAgreementNotes")]
        public TenancyAgreement TenancyAgreement { get; set; }
    }
}
