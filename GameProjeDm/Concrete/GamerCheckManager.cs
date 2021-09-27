using GameProjeDemo.Abstract;
using GameProjeDemo.MernisServiceAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjeDemo.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        IGamerCheckService _gamerCheckService;
        public bool Check(Gamer gamer)
        {
            _gamerCheckService = new MernisServiceAdapter();

            return _gamerCheckService.Check(gamer);
        }
    }
}
