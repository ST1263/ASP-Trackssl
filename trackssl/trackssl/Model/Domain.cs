using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace trackssl.Model
{
    public class Domain
    {
        [Key]
        public int DomainID { get; set; }
        public string DomainName { get; set; }
    }
}
