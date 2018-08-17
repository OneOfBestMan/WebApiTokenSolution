using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyNotes", Schema = "property")]
    public partial class PropertyNote
    {
        public int PropertyId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("NoteId")]
        [InverseProperty("PropertyNotes")]
        public Note Note { get; set; }
        [ForeignKey("PropertyId")]
        [InverseProperty("PropertyNotes")]
        public Property Property { get; set; }
    }
}
