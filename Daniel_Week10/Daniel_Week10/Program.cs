using System;
using System.Collections.Generic;

namespace Daniel_Week10
{
    class Mammal
    {
        //필드(변수)
        public string name;
        public string gender;
        public int age;        //본인 클래스


        //public Mammal(string name, string gender, int age)         //생성자
        //{
        //    this.name = name;
        //    this.gender = gender;
        //    this.age = age;
        //}

        //메소드(함수)
        public virtual void Eat(string meal)
        {
            Console.WriteLine("뽀삐가 식사를 합니다");
        }

        public void Move()
        {

        }
    }

    //    자식 : 부모
    class Human : Mammal
    {
        public override void Eat(string meal)
        {
            base.Eat(meal);
            Console.WriteLine("아니 내가 밥을 먹는다");
        }

        public void Study()
        {
            Console.WriteLine(string.Format("성별이 {0}인 {1}이가 공부를 합니다. 나이는 {2}살입니다.", gender, name, age));
        }
        public void Coding()
        {

        }
    }


    class Car
    {
        public string brand;
        public float speed;

        public void Drive()
        {
            Console.WriteLine(string.Format("{0}만큼 달리고 있습니다", speed));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //Mammal animal = new Mammal();
            //animal.age = 1;
            //animal.gender = "Male";
            //animal.name = "뽀삐";
            ////Console.WriteLine(string.Format("{0} {1} {2}", animal.age, animal.gender, animal.name));
            //animal.Eat("");

            //Human human = new Human();
            //human.age = 10;
            //human.gender = "Female";
            //human.name = "은서";

            //human.Study();
            //human.Eat("");

            Car car = new Car();
            car.speed = 100f;
            car.Drive();
        }
    }
}
