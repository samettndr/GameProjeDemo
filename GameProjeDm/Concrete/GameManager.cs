using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjeDemo.Concrete
{
    public class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + "  : Oyun klendi. ");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "  : Oyun silindi. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "  : Oyun güncellendi. ");
        }
    }
}
