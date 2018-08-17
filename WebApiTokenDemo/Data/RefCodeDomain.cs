using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("RefCodeDomains", Schema = "admin")]
    public partial class RefCodeDomain
    {
        public RefCodeDomain()
        {
            RefCodes = new HashSet<RefCode>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("Domain")]
        public ICollection<RefCode> RefCodes { get; set; }
    }
}
