using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class NoteType
    {
        public NoteType()
        {
            Notes = new HashSet<Note>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("NoteType")]
        public ICollection<Note> Notes { get; set; }
    }
}
