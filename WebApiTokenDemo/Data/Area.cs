using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("Areas", Schema = "property")]
    public partial class Area
    {
        public Area()
        {
            ContractorsAreas = new HashSet<ContractorsArea>();
            Properties = new HashSet<Property>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Area")]
        public ICollection<ContractorsArea> ContractorsAreas { get; set; }
        [InverseProperty("Area")]
        public ICollection<Property> Properties { get; set; }
    }
}
