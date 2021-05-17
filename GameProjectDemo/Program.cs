using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() {Id=1,NationalIdentity="12345678910",FirstName="Muhammed",LastName="Bayri",Birthday="02.01.2000" };

            Gamer gamer2 = new Gamer() { Id = 1, NationalIdentity = "12345", FirstName = "Ahmet", LastName = "Bayri", Birthday = "02.01.2000" };


            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.SignUp(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Update(gamer);

            Console.WriteLine("*****************************************");
            
            gamerManager.SignUp(gamer2);

            Console.WriteLine("*****************************************");

            Game game = new Game() {Id=1,GameName="GTA V",Price=85 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Update(game);

            Console.WriteLine("*****************************************");

            Campaign campaign = new Campaign() {Id=1,CampaignName="Ilk satin alim kampanyasi",Discount=15 };

            GameSaleManager gameSaleManager = new GameSaleManager(campaign);
            gameSaleManager.Sell(gamer, game);


        }
    }
}
