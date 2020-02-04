using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LearningLibrary;

namespace Learning_Intermediate
{
    class Program
    {

        static void Main(string[] args)
        {
                   

        }
        static void DownCasting()
        {
            Shape shape = new Text();
            Text text = (Text)shape;
        }
        static void UpCasting()
        {
            //StreamReader reader = new StreamReader(new MemoryStream());
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Cosma");
            list.Add(new Text());

            var anotherList = new List<Shape>();
        }
        static void Shape()
        {
            var text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width);
        }
        static void Composition()
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

        }
        static void Stopwatch() 
        {
            var timer = new StopWatch();
            timer.Start();
            timer.Stop();
            Console.WriteLine(timer.timespan);
            Console.WriteLine(timer.StartTimer);
            Console.WriteLine(timer.StopTimer);
        }
        static void Cookie()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Cosma";
            Console.WriteLine(cookie["name"]);
        }
        static void DateTime()
        {
            var person = new Person(new DateTime(1990, 1, 2));
            Console.WriteLine(person.Age);
        }
        static void Parse()
        {
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 7));
            Console.WriteLine(calculator.Add(1, 2, 3, 7, 8, 7));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 7, 8, 7 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"{point.X} {point.Y}");

                point.Move(100, 200);
                Console.WriteLine($"{point.X} {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
