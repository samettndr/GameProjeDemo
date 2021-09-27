using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjeDemo.Abstract
{
    public interface IOrderService
    {
        void Order(Game game, Gamer gamer);

        void CampaignOrder(Game game, Gamer gamer, Campaing campaing);
    }
}
