using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class Project
    {
        public Project()
        {
            MaintenanceJobs = new HashSet<MaintenanceJob>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Project")]
        public ICollection<MaintenanceJob> MaintenanceJobs { get; set; }
    }
}
