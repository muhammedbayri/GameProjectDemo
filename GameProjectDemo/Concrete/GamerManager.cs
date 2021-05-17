using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class GamerManager : IGamerService
    {
        private IVerificationService verificationService;

        public GamerManager(IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }

        public void SignUp(Gamer gamer)
        {
            if (!verificationService.Verify(gamer))
            {
                Console.WriteLine(gamer.FirstName + " Kayit edilemedi, bilgileri kontrol ediniz.");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " Kayit edildi.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Silindi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Guncellendi");
        }
    }
}
