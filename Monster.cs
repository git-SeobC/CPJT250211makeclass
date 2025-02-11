using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPJT250211makeclass
{
    public abstract class Monster
    {
        public Monster() { }
        ~Monster() { }


        public int hp;
        public int gold;

        public void Attack()
        {
            Console.WriteLine("Attack");
        }

        public void Die()
        {
            Console.WriteLine("Died");
        }

        public void Move()
        {
            Console.WriteLine("Move");
        }
    }

    public class Goblin : Monster
    {
        public Goblin() { hp = 10; gold = 10; }
        ~Goblin() { }
        public void Attack()
        {
            Console.WriteLine("Goblin Attack");
        }

        void Die()
        {
            Console.WriteLine("Goblin Died");
        }

        public void Move()
        {
            Console.WriteLine("Goblin Move");
        }
    }

    public class Boar : Monster
    {
        public Boar() { }
        ~Boar() { }
        public void Attack()
        {
            Console.WriteLine("Boar Attack");
        }

        void Die()
        {
            Console.WriteLine("Boar Died");
        }

        public void Move()
        {
            Console.WriteLine("Boar Move");
        }
    }

    public class Slime : Monster
    {
        public Slime() { }
        ~Slime() { }
        public void Attack()
        {
            Console.WriteLine("Slime Attack");
        }

        void Die()
        {
            Console.WriteLine("Slime Died");
        }

        public void Move()
        {
            Console.WriteLine("Slime Sliding");
        }
    }
}
