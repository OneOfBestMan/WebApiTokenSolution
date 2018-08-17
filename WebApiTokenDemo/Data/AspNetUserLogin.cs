using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class AspNetUserLogin
    {
        [StringLength(128)]
        public string LoginProvider { get; set; }
        [StringLength(128)]
        public string ProviderKey { get; set; }
        [StringLength(128)]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("AspNetUserLogins")]
        public AspNetUser User { get; set; }
    }
}
