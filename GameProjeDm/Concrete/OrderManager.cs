using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjeDemo.Concrete
{
    class OrderManager
    {
        public void CampaignOrder(Game game, Gamer gamer, Campaing campaing)
        {
            decimal indirimOranı = game.GamePrice - (game.GamePrice * campaing.DiscountRate);

            Console.WriteLine(" Sayın " + gamer.FirstName +campaing.CampaingName + " " + game.GameName + " : Oyununu  " +
               indirimOranı + " TL' ye Satın Aldınız");

        }

        public void Order(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Adlı oyunu satın Aldı : " + game.GameName + "  " + game.GamePrice + " TL ");
        }
    }
}
