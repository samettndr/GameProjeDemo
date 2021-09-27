using GameProjeDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjeDemo.Concrete
{
    class GamerManager
    {
        IGamerCheckService _gamerCheckManager;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckManager = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer) == true)
            {
                Console.WriteLine(" BAŞARILI ");
                Console.WriteLine(gamer.UserName + "   : Oyuncu eklendi  ");
            }
            else
            {
                Console.WriteLine("Yanlış bilgi girişi !");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + "   : Oyuncu silindi ");
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer) == true)
            {
                Console.WriteLine(" ONAYLANDI");
                Console.WriteLine(gamer.UserName + "   : Oyuncu güncellendi  ");
            }
            else
            {
                Console.WriteLine(" Yanlış bilgi girişi !  ");
            }
        }
    }
}
