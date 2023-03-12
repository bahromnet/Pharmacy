using Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Models
{
    public class Sellermen : ISellermen
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adrress { get; set; }
    }
}
