﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    [Table("LedgerTransactionGroupTypes", Schema = "accounts")]
    public partial class LedgerTransactionGroupType
    {
        public LedgerTransactionGroupType()
        {
            LedgerTransactionGroups = new HashSet<LedgerTransactionGroup>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Descr { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("LedgerTransactionGroupType")]
        public ICollection<LedgerTransactionGroup> LedgerTransactionGroups { get; set; }
    }
}
