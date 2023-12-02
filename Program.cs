using System;

namespace testMenuMVVM
{
    
    class Program
    {
        static void Main(string[] args)
        {
            View vue = new View();
            while (true)
            {
                vue.DisplayMenu();

                Console.Write("Choisissez une option : ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        vue.ExecuterExercice1();
                        break;

                    case "2":
                        vue.ExecuterExercice2();
                        break;
                    case "3":
                        vue.ExecuterExercice3();
                        break;

                    case "4":
                        vue.ExecuterExercice4();

                        break;
                    case "5":
                        vue.ExecuterExercice5();
                        break;

                    case "6":
                        vue.ExecuterExercice6();
                        break;

                    case "0":
                        Console.WriteLine("Au revoir !");
                        return;

                    default:
                        Console.WriteLine("Option non valide. Veuillez réessayer.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
