using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("PropertyInspectionTypes", Schema = "property")]
    public partial class PropertyInspectionType
    {
        public PropertyInspectionType()
        {
            PropertyInspections = new HashSet<PropertyInspection>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("InspectionType")]
        public ICollection<PropertyInspection> PropertyInspections { get; set; }
    }
}
