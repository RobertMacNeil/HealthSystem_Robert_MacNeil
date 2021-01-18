using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem_Robert_MacNeil
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            //
            player.ShowStats();
            player.TakeDamage(500);
            player.ShowStats();
            player.TakeDamage(-500);
            player.ShowStats();
            player.TakeDamage(50);
            player.ShowStats();
            player.RegenerateShield(500);
            player.ShowStats();
            player.TakeDamage(50);
            player.ShowStats();
            player.RegenerateShield(-500);
            player.ShowStats();
            player.TakeDamage(75);
            player.ShowStats();
            player.Heal(500);
            player.ShowStats();
            player.TakeDamage(50);
            player.ShowStats();
            player.Heal(-500);
            player.ShowStats();
            player.Heal(50);
            player.ShowStats();

            //

            Console.ReadKey(true);
        }
    }
}
