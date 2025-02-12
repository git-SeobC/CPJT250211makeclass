using System.Security.Cryptography.X509Certificates;

namespace CPJT250211makeclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region test
            Player player = new Player();

            Random rand = new Random();

            int goblinCount = rand.Next(1, 3);
            Goblin[] goblins = new Goblin[goblinCount];
            for (int i = 0; i < goblins.Length; i++)
            {
                goblins[i] = new Goblin();
            }

            int slimeCount = rand.Next(1, 3);
            Slime[] slimes = new Slime[slimeCount];
            for (int i = 0; i < slimes.Length; i++)
            {
                slimes[i] = new Slime();
            }

            int boarCount = rand.Next(1, 5);
            Boar[] boars = new Boar[boarCount];
            for (int i = 0; i < boars.Length; i++)
            {
                boars[i] = new Boar();
            }

            while (true)
            {
                Console.ReadKey();
                Console.Clear();

                player.Move();
                for (int i = 0; i < goblins.Length; i++)
                {
                    goblins[i].Move();
                    goblins[i].Die();
                }
                for (int i = 0; i < slimes.Length; i++)
                {
                    slimes[i].Move();
                }
                for (int i = 0; i < boars.Length; i++)
                {
                    boars[i].Move();
                }
            }
            #endregion
        }
    }
}