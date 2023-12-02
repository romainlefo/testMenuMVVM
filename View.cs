using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMenuMVVM
{
    public class View
    {
        private readonly ViewModel _viewModel;

        public View()
        {
            _viewModel = new ViewModel();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("\n\nMenu :");
            Console.WriteLine("1. Exercice 1 (Addition de deux nombres avec utilisation d'un delegue)");
            Console.WriteLine("2. Exercice 2 (calculer le carré d'un nombre avec une expression lambda)");
            Console.WriteLine("3. Exercice 3 (Implémenter un type anonyme qui comporte un ‘int', un ‘string)");
            Console.WriteLine("4. Exercice 4 (allocation de la mémoire avec delegue)");
            Console.WriteLine("5. Exercice 5");
            Console.WriteLine("6. Exercice 6 (désallocation de la mémoire)");
            Console.WriteLine("0. Quitter (Au revoir)\n\n");

        }

        public void ExecuterExercice1()
        {
            _viewModel.ExecuterExercice1();
        }
        public void ExecuterExercice2()
        {
            _viewModel.ExecuterExercice2();
        }
        public void ExecuterExercice3()
        {
            _viewModel.ExecuterExercice3();
        }
        public void ExecuterExercice4()
        {
            _viewModel.ExecuterExercice4();
        }
        public void ExecuterExercice5()
        {
            _viewModel.ExecuterExercice5();
        }
        public void ExecuterExercice6()
        {
            _viewModel.ExecuterExercice6();
        }
    }
}
      /*  public void Userchoice()
        {
            while (true)
            {
                DisplayMenu();

                Console.Write("Choisissez une option : ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        _viewModel.ExecuterExercice1();
                        break;

                    case "2":
                       _viewModel.ExecuterExercice2();
                        break;
                    case "3":
                        _viewModel.ExecuterExercice3();
                        break;

                    case "4":
                        _viewModel.ExecuterExercice4();
                       
                        break;
                    case "5":
                        _viewModel.ExecuterExercice5();
                        break;

                    case "6":
                        _viewModel.ExecuterExercice6();
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
        }*/
