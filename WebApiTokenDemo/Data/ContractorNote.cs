using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class ContractorNote
    {
        public int ContractorId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("ContractorId")]
        [InverseProperty("ContractorNotes")]
        public Contractor Contractor { get; set; }
        [ForeignKey("NoteId")]
        [InverseProperty("ContractorNotes")]
        public Note Note { get; set; }
    }
}
