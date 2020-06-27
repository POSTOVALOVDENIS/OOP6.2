using System;

namespace OOP6._2
{
    class Class
    {
        private string Metod;

        public Class()
        {
            Metod = "Пусто";
        }
        public Class(string Line)
        {
            if (Line.Length > 10)
                this.Metod = "Слишком длинная строка";
            else
                this.Metod = Line;
        }
        public void Display()
        {
            Console.WriteLine(Metod);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class classone = new Class();
            classone.Display();
            Class classthre = new Class("666");
            classthre.Display();
            Class classtwo = new Class("К сожалению эта стро4ка слишком большая...");
            classtwo.Display();
            Console.ReadKey();
        }

    }

}

