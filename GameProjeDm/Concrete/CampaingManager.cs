using GameProjeDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjeDemo.Concrete
{
    public class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName+" : Kampanya eklendi !");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + " : Kampanya silindi !");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + " : Kampanya güncellendi !");
        }
    }
}
