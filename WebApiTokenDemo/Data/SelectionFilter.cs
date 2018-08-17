using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class SelectionFilter
    {
        public SelectionFilter()
        {
            SelectionFiltersRecords = new HashSet<SelectionFiltersRecord>();
        }

        public int SelectionFilterId { get; set; }
        public int SelectionFilterTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string Descr { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Expires { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Required]
        [StringLength(50)]
        public string UserId { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("SelectionFilterTypeId")]
        [InverseProperty("SelectionFilters")]
        public SelectionFilterType SelectionFilterType { get; set; }
        [InverseProperty("SelectionFilter")]
        public ICollection<SelectionFiltersRecord> SelectionFiltersRecords { get; set; }
    }
}
