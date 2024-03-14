using System;

namespace Daniel_Week11
{

    class Vehicle
    {
        public string name;
        public string brand;
        public float minSpeed;
        public float maxSpeed;

        public void Break()
        {
            Console.WriteLine(string.Format("{0}가 브레이크를 걸었습니다.", name));
            return;
        }

        public float GetAverageSpeed()
        {
            return (minSpeed + maxSpeed) / 2;
        }

        public float Sum(float a, float b) //매개변수(파라미터)
        {
            return a + b;   //반환값(리턴)
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.maxSpeed = 100;
            vehicle.minSpeed = 10;
            vehicle.Break();
            Console.WriteLine(vehicle.GetAverageSpeed());
        }
    }
}
