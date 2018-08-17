using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("MaintenanceJobTypes", Schema = "property")]
    public partial class MaintenanceJobType
    {
        public MaintenanceJobType()
        {
            MaintenanceJobs = new HashSet<MaintenanceJob>();
            MaintenancePreferences = new HashSet<MaintenancePreference>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Type")]
        public ICollection<MaintenanceJob> MaintenanceJobs { get; set; }
        [InverseProperty("MaintenanceJobTypeNavigation")]
        public ICollection<MaintenancePreference> MaintenancePreferences { get; set; }
    }
}
