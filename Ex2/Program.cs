using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cats Pisica1 = new Cats("Dina", 7, "Female");
            Cats Pisica2 = new Cats("Pisi", 2, "Female");
            Cats Pisica3 = new Cats("Leo", 1, "Male");
            Cats Pisica4 = new Cats("Rita", 12, "Female");
            Console.WriteLine(Pisica1.Sound());


            Kitten Pisic1 = new Kitten("May", 1, "Male");
            Kitten Pisic2 = new Kitten("Miu", 2, "Male");
            Kitten Pisic3 = new Kitten("Coco", 3, "Male");
            Kitten Pisic4 = new Kitten("Clau", 3, "Male");
            Console.WriteLine(Pisic1.Sound());

            Dog Catel1 = new Dog("Rumus", 6, "Male");
            Dog Catel2 = new Dog("Benitto", 10, "Male");
            Dog Catel3 = new Dog("Rex", 5, "Male");
            Dog Catel4 = new Dog("Bobby", 12, "Male");
            Dog Catel5 = new Dog("Nana", 9, "Female");

            Dog[] ListaCatei = new Dog[ ] { Catel1, Catel2 , Catel3, Catel4, Catel5 };

            Console.WriteLine(Dog.CalculateAvarage(ListaCatei));
            Cats[] ListaPisici = new Cats[] { Pisica1, Pisica2, Pisica3, Pisica4 };
            Console.WriteLine(Cats.CalculateAvarage(ListaPisici));
            
            Console.ReadLine();
        }
    }
}
