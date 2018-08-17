using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("AutoChargingEvents", Schema = "accounts")]
    public partial class AutoChargingEvent
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
    }
}
