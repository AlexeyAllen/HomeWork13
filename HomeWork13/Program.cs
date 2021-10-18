using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    // задание классов с наследованием.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес");
            string adress = Console.ReadLine();
            Console.WriteLine("Введите длину здания");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину здания");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту здания");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество этажей здания");
            int floors = Convert.ToInt32(Console.ReadLine());

            Building singleFloor = new Building(adress, length, width, height);
            Multibuilding multiFloor = new Multibuilding(adress, length, width, height, floors);
            singleFloor.Print();
            multiFloor.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Building(string adress, int length, int width, int height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Информация о здании:");
            Console.WriteLine("Адрес: {0}", Adress);
            Console.WriteLine("Длина: {0}", Length);
            Console.WriteLine("Ширина: {0}", Width);
            Console.WriteLine("Высота: {0}", Height);
        }
    }
    sealed class Multibuilding: Building
    {
        public int Floors { get; set; }
        public Multibuilding(string adress, int length, int width, int height, int floors)
            :base(adress, length, width, height)
        {
            Floors = floors;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Этажность: {0}", Floors);
        }
    }
}
