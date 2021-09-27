using GameProjeDemo.Abstract;
using GameProjeDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer { FirstName = "Samet", LastName = "Önder", Id = 1,
                
                NationalityId = 19766652002, UserName = "SMT", 
                DateOfBirth = new DateTime(1997, 04, 29) };

            Gamer gamer2 = new Gamer
            {
                Id = 2,
                DateOfBirth = new DateTime(1997, 09, 16),
                FirstName = " NAZLI ",
                LastName = " CEKİÇ ",
                UserName = " Sakar ",
                NationalityId = 55555555
            };



            gamerManager.Add(gamer1);

            Console.WriteLine("----------------------------");

            CampaingManager campaingManager = new CampaingManager();
            Campaing campaign = new Campaing { Id = 1, CampaingName = "  %60 İNDİRİMLİ ", DiscountRate = 0.60M };
            Campaing campaign2 = new Campaing { Id = 2, CampaingName = "  %80 İNDİRİMLİ ", DiscountRate = 0.80M };
            campaingManager.Add(campaign);

            Console.WriteLine("----------------------------");

            GameManager gameManager = new GameManager();
            Game game1 = new Game { Id = 1, GameName = "Red Dead 2 ", GamePrice = 200 };
            Game game2 = new Game { Id = 2, GameName = "GTA 5  ", GamePrice = 140 };

            gameManager.Add(game2);
            gameManager.Update(game1);

            Console.WriteLine("----------------------------");

            OrderManager orderManager = new OrderManager();

            orderManager.CampaignOrder(game1, gamer1, campaign);
            orderManager.Order(game2, gamer2);

            Console.ReadLine();
        }
    }
}
