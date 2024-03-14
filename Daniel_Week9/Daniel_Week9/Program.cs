using System;

namespace Daniel_Week9
{
    class Human
    {
        public string name;
        public int age;
        public float height;
        public float weight;


        //public void SetWeight(float weight) => this.weight = weight;
        //public float GetWeight()
        //{
        //    return weight;
        //}
        //public, protected, private

        public Human(string name, int age, float height, float weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            Console.WriteLine(this.name + "생성됐습니다.");
        }
        
        public void Work()
        {
            Console.WriteLine(name + "이(가) 일하고 있습니다.");
        }

        public void HaveMeal(string food)
        {
            Console.WriteLine(name + "이(가) " + food + "를 먹었습니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("김태욱", 22, 188, 90);

            human.Work();
        }
    }
}
