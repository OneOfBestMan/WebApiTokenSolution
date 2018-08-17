﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class DebtRecoveryOperationNote
    {
        public int DebtRecoveryOperationId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("DebtRecoveryOperationId")]
        [InverseProperty("DebtRecoveryOperationNotes")]
        public DebtRecoveryOperation DebtRecoveryOperation { get; set; }
        [ForeignKey("NoteId")]
        [InverseProperty("DebtRecoveryOperationNotes")]
        public Note Note { get; set; }
    }
}
