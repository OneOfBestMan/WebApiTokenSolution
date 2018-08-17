using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class ContractorType
    {
        public ContractorType()
        {
            Contractors = new HashSet<Contractor>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool SystemType { get; set; }
        public bool OnePerArea { get; set; }
        public bool OnePerTenancy { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("ContractorType")]
        public ICollection<Contractor> Contractors { get; set; }
    }
}
