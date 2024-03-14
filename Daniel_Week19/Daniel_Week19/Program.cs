using System;

namespace Daniel_Week19
{
    class Human
    {
        //private <- 접근성이 낮음(보안성이 높다), public <- 접근성이 높다(보안성이 낮다)
        public string name;
        public string id;      //주민번호
        public int age;
        public string gender;

        public Human(string name, string id, int age, string gender)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.gender = gender;
        }

        public void Eating()
        {
            Console.WriteLine($"{name}이(가) 밥을 먹습니다.");
        }
    }

    class Program
    {
        static int Volume(int width, int height, int depth)
        {
            return width * height * depth;
        }

        static int SurfaceArea(int width, int height, int depth)
        {
            return (width * height * 2) + (width * depth * 2) + (height * depth * 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Volume(10, 10, 10));
            Console.WriteLine(SurfaceArea(10, 10, 10));

            Human human = new Human("김태욱", "001111-3333333", 22, "남성");
            human.Eating();
        }
    }
}
