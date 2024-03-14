using System;

namespace Daniel_Week12
{
    public abstract class Animal        //추상 클래스
    {
        public string name;

        public abstract void Move();        //추상 메소드

        public virtual void Eat()           //가상 메소드
        {
            Console.Write("먹습니다");
        }
    }

    public class Human : Animal     //자식 : 부모
    {
        public override void Move()     //부모 클래스의 메소드를 자식 클래스에서 재정의 하는 것을 "오버라이딩"
        {
            Console.WriteLine(nameof(Human) + "이 걷습니다.");
        }

        public void SaySomething()
        {
            Console.WriteLine(name + "이 뭔가 이야기합니다");
        }
        public void SaySomething(string something)      //오버로딩
        {
            Console.WriteLine(string.Format("{0}이 {1}라고 이야기 합니다.", name, something));
        }
    }

    public abstract class Vihicle
    {
        public string name;

        public abstract void Move();
    }

    public class Car : Vihicle
    {
        public override void Move()
        {
            Console.WriteLine(nameof(Car) + "가 달립니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Move();

            human.name = "김태욱";
            human.SaySomething();
            human.SaySomething("블라블라");
            Console.WriteLine();

            Car car = new Car();
            Console.WriteLine(car as Vihicle);
        }
    }
}
