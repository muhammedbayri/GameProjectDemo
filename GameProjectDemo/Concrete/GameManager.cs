using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameService
    {

        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Guncellendi");
        }
    }
}
