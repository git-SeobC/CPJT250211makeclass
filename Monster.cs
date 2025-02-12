using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPJT250211makeclass
{
    public abstract class Monster : Character
    {
        public Monster()
        {
            Console.WriteLine("몬스터 생성자");
        }
        ~Monster()
        {
            Console.WriteLine("몬스터 소멸자");
        }

        public int Hp { get; set; }
        public int Gold { get; set; }

        public void Attack()
        {
            Console.WriteLine("Moster Attack");
        }

        public void Die()
        {
            Console.WriteLine("Moster Died");
        }

        public virtual void Move() // 자식 클래스에서 오버라이드될 함수를 표현 할때 virtual 키워드 사용
        {
            Console.WriteLine("Moster Move");
        }
    }

    public class Goblin : Monster
    {
        public Goblin() { Hp = 10; Gold = 10; }
        ~Goblin() { }

        public override void Move() // 자식 클래스에서 오버라이드된 함수를 표현 할 때 override 키워드 써주어야 함
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
