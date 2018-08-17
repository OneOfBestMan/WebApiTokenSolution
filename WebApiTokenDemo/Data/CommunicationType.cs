﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class CommunicationType
    {
        public CommunicationType()
        {
            Communications = new HashSet<Communication>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("CommunicationType")]
        public ICollection<Communication> Communications { get; set; }
    }
}
