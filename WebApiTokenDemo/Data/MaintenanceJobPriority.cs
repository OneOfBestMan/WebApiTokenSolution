using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("MaintenanceJobPriorities", Schema = "property")]
    public partial class MaintenanceJobPriority
    {
        public MaintenanceJobPriority()
        {
            MaintenanceJobs = new HashSet<MaintenanceJob>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string TimeScale { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Priority")]
        public ICollection<MaintenanceJob> MaintenanceJobs { get; set; }
    }
}
