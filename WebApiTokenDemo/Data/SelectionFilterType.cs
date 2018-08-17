using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class SelectionFilterType
    {
        public SelectionFilterType()
        {
            SelectionFilters = new HashSet<SelectionFilter>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("SelectionFilterType")]
        public ICollection<SelectionFilter> SelectionFilters { get; set; }
    }
}
