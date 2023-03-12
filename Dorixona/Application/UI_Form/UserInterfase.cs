using Domain.Core.Enums;
using Domain.Core.Interfaces;
using Domain.Core.Models;
using Infrastructura.CRUD;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UI_Form
{
    public class UserInterfase
    {
        static CreateDoriClass createDoriClass = new();
        static DeleteDoriClass deleteDori = new();
        static UpdateDoriClass updateDori = new();
        static ReadDoriClass readDori = new();
        public static void Run()
        {
            Console.WriteLine("1. Dori qo'shish");
            Console.WriteLine("2. Dori borligini tekshirish");
            Console.WriteLine("3. Dorini tahrirlash");
            Console.WriteLine("4. Dorini O'chirish");
            Console.WriteLine("5. Dorini Sotish");
            Console.WriteLine("6. Dorilar hisoboti");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int chooseOne))
            {
                Console.Clear();
                Run();
            }
            switch (chooseOne)
            {
                case 1:
                    {
                        Console.Clear();
                        AddNewDori();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        BormiOzi();
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Tahrirlash();
                    }
                    break;
                case 4:
                    {
                        

                    }
                    break;
                case 5:
                    {
                        Console.Clear();
                        Sotish();
                    }
                    break;
                case 6:
                    {
                        Console.Clear();
                        Hisobotlar();
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        Run();
                    }
                    break;
            }

        }
        public static void AddNewDori()
        {
            Console.WriteLine("Dori Id sini kiriting:");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int doriId))
            {
                Console.Clear();
                Run();
            }
            Console.WriteLine("Dori Name ini kiriting:");
            Console.Write(">> ");
            string? name = Console.ReadLine();
            Console.WriteLine("Dori Description ini kiriting:");
            Console.Write(">> ");
            string? des = Console.ReadLine();
            Console.WriteLine("Dori Soni ini kiriting:");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int soni))
            {
                Console.Clear();
                Run();
            }
            Console.WriteLine("Dori Turini tanlang:");
            Console.Write(">> ");
            Console.WriteLine("Uylanganmisiz? ");
            Console.WriteLine("1. None");
            Console.WriteLine("2. Tabletka");
            Console.WriteLine("3. Ukol Dori");
            Console.WriteLine("4. Eritma");
            Console.Write(">> ");
            DoriTuri dt = DoriTuri.None;
            if (!int.TryParse(Console.ReadLine(), out int doriTuri))
            {
                Console.Clear();
                Run();
            }
            switch (doriTuri)
            {
                case 1:
                    {
                        dt = DoriTuri.None;
                    }
                    break;
                case 2:
                    {
                        dt = DoriTuri.Tabletka;
                    }
                    break;
                case 3:
                    {
                        dt = DoriTuri.Ukol_dori;
                    }
                    break;
                case 4:
                    {
                        dt = DoriTuri.Eritma;
                    }
                    break;
                default:
                    Console.Clear();
                    Run();
                    break;
            }
            Console.WriteLine("Ishlab chiqarilgan sanasini kiriting: ");
            Console.Write(">> ");
            DateOnly dateOnly1 = new DateOnly(int.Parse(Console.ReadLine()!), int.Parse(Console.ReadLine()!), int.Parse(Console.ReadLine()!));
            Console.WriteLine("Yaroqlilik muddatini kiriting: ");
            Console.Write(">> ");
            DateOnly dateOnly2 = new DateOnly(int.Parse(Console.ReadLine()!), int.Parse(Console.ReadLine()!), int.Parse(Console.ReadLine()!));
            createDoriClass.AddDori(new Dori()
            {
                Id = doriId,
                Name = name,
                Description = des,
                Soni = soni,
                Turi = dt,
                IshlabCHiqarilganSanasi = dateOnly1,
                YaroqlilikMuddati = dateOnly2
            });
            Console.Clear();
            Console.WriteLine("Dori Qo'shildi");
            Run();
        }

        public static void BormiOzi()
        {
            Console.WriteLine("Dori ID sini kiriting:");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int doriId))
            {
                Console.Clear();
                Run();
            }
            var dori = readDori.ReadDori(doriId);
            string json = JsonConvert.SerializeObject(dori, Formatting.Indented);
            if (dori != null)
            {
                Console.WriteLine(json);
            }
            else
            {
                Console.WriteLine("Dori topilmadi");
            }
            Console.WriteLine("Menyuga qaytish ushun ixtiyoriy tugmani bosing");
            Console.ReadKey();
            Console.Clear();
            Run();

        }

        public static void Tahrirlash()
        {
            Console.WriteLine("Qaysi dorini tahrirlamoqchisiz, ID sini kiriting: ");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int doriId))
            {
                Console.Clear();
                Run();
            }
            Console.WriteLine("Dori Name ini kiriting (Note: Agar qiymat kiritilmasa, eski qaymatida qoladi):");
            Console.Write(">> ");
            string? name = Console.ReadLine();
            Console.WriteLine("Dori Description ini kiriting (Note: Agar qiymat kiritilmasa, eski qaymatida qoladi):");
            Console.Write(">> ");
            string? des = Console.ReadLine();
            Console.WriteLine("Dori Soni ini kiriting (Note: Agar qiymat kiritilmasa, eski qaymatida qoladi):");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int soni))
            {
                Console.Clear();
                Run();
            }
            Console.WriteLine("Dori Turini tanlang (Note: Agar qiymat kiritilmasa, eski qaymatida qoladi):");
            Console.Write(">> ");
            Console.WriteLine("Uylanganmisiz? ");
            Console.WriteLine("1. None");
            Console.WriteLine("2. Tabletka");
            Console.WriteLine("3. Ukol Dori");
            Console.Write(">> ");
            DoriTuri dt = DoriTuri.None;
            if (!int.TryParse(Console.ReadLine(), out int doriTuri))
            {
                Console.Clear();
                Run();
            }
            switch (doriTuri)
            {
                case 1:
                    {
                        dt = DoriTuri.None;
                    }
                    break;
                case 2:
                    {
                        dt = DoriTuri.Tabletka;
                    }
                    break;
                case 3:
                    {
                        dt = DoriTuri.Ukol_dori;
                    }
                    break;
                default:
                    Console.Clear();
                    Run();
                    break;
            }
            bool changeDori = updateDori.UpdateDori(doriId, new Dori()
            {
                Name = name,
                Description = des,
                Soni = soni,
                Turi = dt,
            });
            if (changeDori)
            {
                Console.Clear();
                Console.WriteLine("Dori Qo'shildi");
                Run();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dori mavlud emas");
                Run();
            }
        }

        public static void DeleteDori()
        {
            Console.WriteLine("O'chirilishi kerak bo'lgan Dori ID sini kiriting:");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int doriId))
            {
                Console.Clear();
                Run();
            }
            bool delDori = deleteDori.DeleteDori(doriId);
            if (delDori)
            {
                Console.WriteLine("Dori o'chirildi");
            }
            else
            {
                Console.WriteLine("Dori topilmadi");
            }
        }

        public static void Sotish()
        {
            Console.WriteLine("Dori ID sini kiriting");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int doriId))
            {
                Console.Clear();
                Console.WriteLine("To'g'ri formatta kiriting");
                Run();
            }
            Console.WriteLine("Sotilayotgan dorini sonini kiriting: ");
            if (!int.TryParse(Console.ReadLine(), out int doriSoni))
            {
                Console.Clear();
                Console.WriteLine("To'g'ri formatta kiriting");
                Run();
            }
            bool doriS = DoriSotish.Sotish(doriId, doriSoni);
            if (doriS)
            {
                Console.Clear();
                Console.WriteLine("Dori sotildi");
                Run();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dori topilmadi yoki kam miqdorda qolgan");
                Run();
            }

        }


        public static void Hisobotlar()
        {
            Console.WriteLine("1. Eng ko'p sotilgan dori");
            Console.WriteLine("2. Eng kam sotilgan dorilar 5 ligi");
            Console.WriteLine("3. Yaroqlilik muddati tugashiga 1 oy qolgan dorilar ro'yxati");
            Console.WriteLine("0. Orqaga qaytish");
            Console.Write(">> ");
            if (!int.TryParse(Console.ReadLine(), out int chooseOne))
            {
                Console.Clear();
                Hisobotlar();
            }
            switch (chooseOne)
            {
                case 1:
                    {
                        Console.Clear();
                        Hisobot.EngKopSotilganDori();
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Hisobot.EngKamSotilganDorilar5Ligi();
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Hisobot.YaroqlilikMuddati1OyQolganDorilar();
                    }
                    break;
                case 0:
                    {
                        Console.Clear();
                        Run();
                    }
                    break;
                default:
                    {
                        Console.Clear();
                        Hisobotlar();
                    }
                    break;
            }
        }

    }
}
