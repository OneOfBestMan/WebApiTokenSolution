using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class CommunicationNote
    {
        public int CommunicationId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("CommunicationId")]
        [InverseProperty("CommunicationNotes")]
        public Communication Communication { get; set; }
        [ForeignKey("NoteId")]
        [InverseProperty("CommunicationNotes")]
        public Note Note { get; set; }
    }
}
