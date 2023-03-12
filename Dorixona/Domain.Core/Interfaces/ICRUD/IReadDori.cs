using Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Interfaces.ICRUD
{
    public interface IReadDori
    {
        Dori ReadDori(int doriId);
    }
}
