using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTokenDemo.Data
{
    public partial class EmailSmtpClient
    {
        public EmailSmtpClient()
        {
            DebtChaseMethods = new HashSet<DebtChaseMethod>();
        }

        public int EmailSmtpClientId { get; set; }
        [Required]
        [StringLength(255)]
        public string Username { get; set; }
        [Required]
        [StringLength(255)]
        public string Password { get; set; }
        [Required]
        [StringLength(255)]
        public string Host { get; set; }
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        [Required]
        [StringLength(255)]
        public string FromEmailAddress { get; set; }
        [Required]
        [StringLength(255)]
        public string FromDisplayName { get; set; }
        [StringLength(255)]
        public string SignatureHtml { get; set; }
        [StringLength(255)]
        public string SignatureText { get; set; }
        public bool SmsUsage { get; set; }
        public bool SendCopyTofromAddressViaBcc { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("EmailSmtpClient")]
        public ICollection<DebtChaseMethod> DebtChaseMethods { get; set; }
    }
}
