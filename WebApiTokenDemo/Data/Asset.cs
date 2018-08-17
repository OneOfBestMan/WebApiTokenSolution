using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("Assets", Schema = "accounts")]
    public partial class Asset
    {
        public Asset()
        {
            Properties = new HashSet<Property>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        [StringLength(5)]
        public string AssetType { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PurchaseDate { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? PurchasePrice { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SoldDate { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? SoldPrice { get; set; }
        [Column(TypeName = "decimal(7, 5)")]
        public decimal? AnnualDepreciationRate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ValuationDate { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? ValuationPrice { get; set; }
        public int? OracleId { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Asset")]
        public ICollection<Property> Properties { get; set; }
    }
}
