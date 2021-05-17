using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        Campaign campaign;

        public GameSaleManager(Campaign campaign)
        {
            this.campaign = campaign;
        }

        public void Sell(Gamer gamer, Game game)
        {
            double newPrice = game.Price-(game.Price*campaign.Discount/100);
            Console.WriteLine(gamer.FirstName + " " + game.GameName + " Oyununu satin aldi : " + newPrice);
        }
    }
}
