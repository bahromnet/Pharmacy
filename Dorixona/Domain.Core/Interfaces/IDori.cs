using Domain.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Interfaces
{
    public interface IDori
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Soni { get; set; }
        public int SotilganSoni { get; set; }
        public DoriTuri? Turi { get; set; }
        public DateOnly IshlabCHiqarilganSanasi { get; set; }
        public DateOnly YaroqlilikMuddati { get; set; }

    }
}
