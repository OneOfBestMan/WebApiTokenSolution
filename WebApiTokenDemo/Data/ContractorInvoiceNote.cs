using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("ContractorInvoiceNotes", Schema = "accounts")]
    public partial class ContractorInvoiceNote
    {
        public int ContractorInvoiceId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("ContractorInvoiceId")]
        [InverseProperty("ContractorInvoiceNotes")]
        public ContractorInvoice ContractorInvoice { get; set; }
        [ForeignKey("NoteId")]
        [InverseProperty("ContractorInvoiceNotes")]
        public Note Note { get; set; }
    }
}
