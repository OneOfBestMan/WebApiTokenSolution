using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LandlordNotes", Schema = "letting")]
    public partial class LandlordNote
    {
        public int LandlordId { get; set; }
        public int NoteId { get; set; }
        [Column("dummy")]
        [StringLength(1)]
        public string Dummy { get; set; }

        [ForeignKey("LandlordId")]
        [InverseProperty("LandlordNotes")]
        public Landlord Landlord { get; set; }
        [ForeignKey("NoteId")]
        [InverseProperty("LandlordNotes")]
        public Note Note { get; set; }
    }
}
