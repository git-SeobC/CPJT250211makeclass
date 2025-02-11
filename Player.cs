using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPJT250211makeclass
{
    public class Player
    {
        public int Hp;
        public int Gold;

        public Player()
        {
            Hp = 100;
            Gold = 0;
            Console.WriteLine("Player Create");
        }

        public Player(int param_Hp, int param_Gold) // 생성자 오버로딩
        {
            Hp = param_Hp;
            Gold = param_Gold;
            Console.WriteLine("Player Create Param");
        }

        ~Player() // 자동으로 호출
        {
            // Network, DB 종료할 때 소멸자에 작성 많이 함
            Console.WriteLine("Player Delete");
        }

        public void Attack(Monster monster)
        {
            Console.WriteLine("Player Attack");
        }

        public void Move()
        {
            Console.WriteLine("Player Move");
        }

        public void Pickup()
        {
            Console.WriteLine("Pickup Gold");

        }

        public void Die()
        {
            Console.WriteLine("You Died");
        }

    }
}
