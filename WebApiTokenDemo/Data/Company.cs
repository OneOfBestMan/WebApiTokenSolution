using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class Company
    {
        public Company()
        {
            Branches = new HashSet<Branch>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Company")]
        public ICollection<Branch> Branches { get; set; }
    }
}
