using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class DebtRecoveryActionNote
    {
        public int DebtRecoveryActionId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("DebtRecoveryActionId")]
        [InverseProperty("DebtRecoveryActionNotes")]
        public DebtRecoveryAction DebtRecoveryAction { get; set; }
        [ForeignKey("NoteId")]
        [InverseProperty("DebtRecoveryActionNotes")]
        public Note Note { get; set; }
    }
}
