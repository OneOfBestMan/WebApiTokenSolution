using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("AccommodationTypes", Schema = "property")]
    public partial class AccommodationType
    {
        public AccommodationType()
        {
            Accommodations = new HashSet<Accommodation>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("AccommodationType")]
        public ICollection<Accommodation> Accommodations { get; set; }
    }
}
