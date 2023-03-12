using Domain.Core.Interfaces.ICRUD;
using Domain.Core.Models;
using Infrastructura.Paths_DB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructura.CRUD
{
    public class ReadDoriClass : IReadDori
    {
        static List<Dori>? doriList = new List<Dori>();
        public Dori ReadDori(int doriId)
        {
            if (!File.Exists(Path_DB.path_Dori_DB))
            {
                File.Create(Path_DB.path_Dori_DB).Dispose();
            }
            else
            {
                doriList = JsonConvert.DeserializeObject<List<Dori>>(File.ReadAllText(Path_DB.path_Dori_DB));
            }
            var hasDori = doriList?.FirstOrDefault(x => x.Id.Equals(doriId));
            return hasDori;
        }
    }
}
