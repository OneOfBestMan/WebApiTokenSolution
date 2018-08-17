using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("MaintenancePreferences", Schema = "property")]
    public partial class MaintenancePreference
    {
        public int Id { get; set; }
        public int MaintenanceJobType { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Preference { get; set; }
        public int? Landlord { get; set; }
        public int? Property { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("Landlord")]
        [InverseProperty("MaintenancePreferences")]
        public Landlord LandlordNavigation { get; set; }
        [ForeignKey("MaintenanceJobType")]
        [InverseProperty("MaintenancePreferences")]
        public MaintenanceJobType MaintenanceJobTypeNavigation { get; set; }
        [ForeignKey("Property")]
        [InverseProperty("MaintenancePreferences")]
        public Property PropertyNavigation { get; set; }
    }
}
