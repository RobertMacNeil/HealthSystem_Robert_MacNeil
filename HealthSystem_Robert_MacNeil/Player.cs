using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem_Robert_MacNeil
{
    class Player
    {
        private int maxHealth;
        private int maxShield;
        private int health;
        private int shield;
        private int lives;

        public Player()
        {
            //initialized because of game (Idea that leveling up can change the max values(RPG Game))
            maxHealth = 100;
            maxShield = 100;

            health = 100;
            shield = 100;
            lives = 3;
        }

        public void ShowStats()
        {
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();
        }

        private void LoseLife()
        {
            Console.WriteLine("Player has lost a life");
            lives = lives - 1;
            if (lives == 0)
            {
                Console.Clear();
                Console.WriteLine("You have fallen... Game Over");
            }
            else
            {
                health = maxHealth;
                shield = maxShield;
            }
            Console.WriteLine();
        }

        public void GainLife()
        {
            Console.WriteLine("Player is about to gain a life");
            lives = lives + 1;
            Console.WriteLine("The gods have blessed you an extra life!");
            Console.WriteLine();
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine("Player is about to take " + damage + " damage");
            if (damage <= 0)
            {
                Console.WriteLine("HAHA! Such a puny attack won't hurt you!");
                return;
            }
            int carriedDamage;

            shield = shield - damage;
            if (shield < 0)
            {
                carriedDamage = shield * -1;
                shield = 0;
                health = health - carriedDamage;
                Console.WriteLine("Your shield is broken! You took " + carriedDamage + " damage!");
                if (health <= 0)
                {
                    LoseLife();
                    return;
                }
            }
            Console.WriteLine();
        }

        public void Heal(int heal)
        {
            Console.WriteLine("Player is about to gain " + heal + " health");
            if (heal <= 0)
            {
                Console.WriteLine("Sorry, the power was not enough to heal your wounds.");
                return;
            }
            health = health + heal;
            if (health >= maxHealth)
            {
                health = maxHealth;
                Console.WriteLine("You are at your max health of: " + maxHealth);
            }
            Console.WriteLine("You healed " + heal + " health!");
            Console.WriteLine();
        }

        public void RegenerateShield(int regen)
        {
            Console.WriteLine("Player is about to gain " + regen + " shield");
            if (regen <= 0)
            {
                Console.WriteLine("Sorry the energy could not rebuild your shield.");
                return;
            }
            shield = shield + regen;
            if (shield >= maxShield)
            {
                shield = maxShield;
                Console.WriteLine("You are at your max shield of: " + maxShield);
            }
            Console.WriteLine("You gained " + regen + " shield!");
            Console.WriteLine();
        }
    }
}
