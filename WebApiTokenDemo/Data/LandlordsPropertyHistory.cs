using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LandlordsPropertyHistories", Schema = "letting")]
    public partial class LandlordsPropertyHistory
    {
        public LandlordsPropertyHistory()
        {
            PropertysLandlordHistories = new HashSet<PropertysLandlordHistory>();
        }

        public int LandlordId { get; set; }
        public int PropertysLandlordHistoryId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Share { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("LandlordId")]
        [InverseProperty("LandlordsPropertyHistories")]
        public Landlord Landlord { get; set; }
        [ForeignKey("PropertysLandlordHistoryId")]
        [InverseProperty("LandlordsPropertyHistories")]
        public PropertysLandlordHistory PropertysLandlordHistory { get; set; }
        [InverseProperty("LandlordsPropertyHistory")]
        public ICollection<PropertysLandlordHistory> PropertysLandlordHistories { get; set; }
    }
}
