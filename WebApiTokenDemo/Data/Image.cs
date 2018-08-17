using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class Image
    {
        public Image()
        {
            Properties = new HashSet<Property>();
        }

        public int Id { get; set; }
        [Required]
        [Column("filename")]
        [StringLength(255)]
        public string Filename { get; set; }
        public int AccommodationId { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("AccommodationId")]
        [InverseProperty("Images")]
        public Accommodation Accommodation { get; set; }
        [InverseProperty("MainImage")]
        public ICollection<Property> Properties { get; set; }
    }
}
