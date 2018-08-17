using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerNotes", Schema = "accounts")]
    public partial class LedgerNote
    {
        public int LedgerId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("LedgerId")]
        [InverseProperty("LedgerNotes")]
        public Ledger Ledger { get; set; }
        [ForeignKey("NoteId")]
        [InverseProperty("LedgerNotes")]
        public Note Note { get; set; }
    }
}
