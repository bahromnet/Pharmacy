using Domain.Core.Enums;
using Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Models
{
    public class Dori : IDori
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Soni { get; set; }
        public int SotilganSoni { get; set; } = 0;
        public DoriTuri? Turi { get; set; }
        public DateOnly IshlabCHiqarilganSanasi { get; set; }
        public DateOnly YaroqlilikMuddati { get; set; }
    }
}
