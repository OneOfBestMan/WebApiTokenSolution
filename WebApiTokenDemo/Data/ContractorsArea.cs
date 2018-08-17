using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class ContractorsArea
    {
        public int ContractorId { get; set; }
        public int AreaId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("AreaId")]
        [InverseProperty("ContractorsAreas")]
        public Area Area { get; set; }
        [ForeignKey("ContractorId")]
        [InverseProperty("ContractorsAreas")]
        public Contractor Contractor { get; set; }
    }
}
