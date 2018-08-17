using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class PaymentPlan
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        [StringLength(2)]
        public string GracePeriod { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }
    }
}
