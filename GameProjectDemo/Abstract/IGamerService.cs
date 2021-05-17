using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public interface IGamerService
    {
        void SignUp(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
