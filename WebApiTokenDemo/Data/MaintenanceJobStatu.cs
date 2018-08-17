using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("MaintenanceJobStatus", Schema = "property")]
    public partial class MaintenanceJobStatu
    {
        public MaintenanceJobStatu()
        {
            MaintenanceJobs = new HashSet<MaintenanceJob>();
        }

        [Key]
        [StringLength(1)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("StatusCodeNavigation")]
        public ICollection<MaintenanceJob> MaintenanceJobs { get; set; }
    }
}
