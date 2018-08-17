using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class SelectionFiltersRecord
    {
        public int SelectionFilterId { get; set; }
        public int RecId { get; set; }
        public int? OrderNo { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [ForeignKey("SelectionFilterId")]
        [InverseProperty("SelectionFiltersRecords")]
        public SelectionFilter SelectionFilter { get; set; }
    }
}
