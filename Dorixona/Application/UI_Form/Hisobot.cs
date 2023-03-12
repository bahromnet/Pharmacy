using Domain.Core.Interfaces;
using Domain.Core.Models;
using Infrastructura.Paths_DB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UI_Form
{
    public class Hisobot
    {
        static List<Dori>? doriList = new List<Dori>();

        public static void EngKopSotilganDori()
        {
            if (!File.Exists(Path_DB.path_Dori_DB))
            {
                File.Create(Path_DB.path_Dori_DB).Dispose();
            }
            else
            {
                doriList = JsonConvert.DeserializeObject<List<Dori>>(File.ReadAllText(Path_DB.path_Dori_DB));
            }
            var kopSotilganDori = (from dori in doriList
                                     orderby dori.SotilganSoni descending
                                     where dori.SotilganSoni > 0
                                     select dori).Take(1);

            string json = JsonConvert.SerializeObject(kopSotilganDori, Formatting.Indented);
            Console.WriteLine(json);
            Console.WriteLine();
            Console.WriteLine("Menyuga qaytish ushun ixtiyoriy tugmani bosing");
            Console.ReadKey();
            Console.Clear();
            UserInterfase.Hisobotlar();
            //Console.WriteLine($"Id: {kopSotilganDori.Id}, Name: {kopSotilganDori.Name}, Sotilgan soni: {kopSotilganDori.SotilganSoni}");
        }

        public static void EngKamSotilganDorilar5Ligi()
        {
            if (!File.Exists(Path_DB.path_Dori_DB))
            {
                File.Create(Path_DB.path_Dori_DB).Dispose();
            }
            else
            {
                doriList = JsonConvert.DeserializeObject<List<Dori>>(File.ReadAllText(Path_DB.path_Dori_DB));
            }
            var engKamSotilganDorilar5Ligi = (from dori in doriList
                                              orderby dori.SotilganSoni
                                              where dori.SotilganSoni > 0
                                              select dori).Take(5);
            foreach (var item in engKamSotilganDorilar5Ligi)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Sotilgan soni: {item.SotilganSoni}");
            }
            Console.WriteLine();
            Console.WriteLine("Menyuga qaytish ushun ixtiyoriy tugmani bosing");
            Console.ReadKey();
            Console.Clear();
            UserInterfase.Hisobotlar();
        }

        public static void YaroqlilikMuddati1OyQolganDorilar()
        {
            if (!File.Exists(Path_DB.path_Dori_DB))
            {
                File.Create(Path_DB.path_Dori_DB).Dispose();
            }
            else
            {
                doriList = JsonConvert.DeserializeObject<List<Dori>>(File.ReadAllText(Path_DB.path_Dori_DB));
            }
            var dorilar = from dori in doriList
                          where (dori.YaroqlilikMuddati.Month - DateTime.Now.Month <= 1)
                          && (dori.YaroqlilikMuddati.Year !<= DateTime.Now.Year)
                          select dori;
            foreach (var item in dorilar)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Yaroqlilik muddati: {item.YaroqlilikMuddati}");
            }
            Console.WriteLine();
            Console.WriteLine("Menyuga qaytish ushun ixtiyoriy tugmani bosing");
            Console.ReadKey();
            Console.Clear();
            UserInterfase.Hisobotlar();
        }
    }
}
