using System;
using System.ComponentModel.DataAnnotations;

namespace trackssl.Model
{
    public class Domain
    {
        [Key]
        public int DomainID { get; set; }
        public string DomainName { get; set; }
        public DateTime CreatedAT { get; set; }
    }
}
