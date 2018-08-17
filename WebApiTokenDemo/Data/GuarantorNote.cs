using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("GuarantorNotes", Schema = "letting")]
    public partial class GuarantorNote
    {
        public int GuarantorId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("GuarantorId")]
        [InverseProperty("GuarantorNotes")]
        public Guarantor Guarantor { get; set; }
        [ForeignKey("NoteId")]
        [InverseProperty("GuarantorNotes")]
        public Note Note { get; set; }
    }
}
