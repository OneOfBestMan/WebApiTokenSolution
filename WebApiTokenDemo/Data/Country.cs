using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class Country
    {
        public Country()
        {
            Landlords = new HashSet<Landlord>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(2)]
        public string Alpha2 { get; set; }
        [Required]
        [StringLength(3)]
        public string Aplha3 { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Nationality")]
        public ICollection<Landlord> Landlords { get; set; }
    }
}
