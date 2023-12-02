using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testMenuMVVM
{
    delegate int delg(int v1, int v2);
    delegate int delg2(int v1);
    delegate void delg3(int v1, string m1);
    delegate void delg4();
    public class ViewModel
    {
        private readonly Model _modele;
        private Object obj;


        public ViewModel()
        {
            _modele = new Model();
        }

        
        public void ExecuterExercice1()
        {
            delg delegue = new delg(_modele.Addition);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("exercice 1 (addition)");
            Console.WriteLine("choisissez le nombre 1 : ");
            int nb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("choisissez le nombre 2 : ");
            int nb2 = int.Parse(Console.ReadLine());
            int resultat = delegue.Invoke(nb1, nb2);
            Console.WriteLine($"le resultat de l'addition est : {resultat}");
            Console.WriteLine("-----------------------------");
            
        }
        public void ExecuterExercice2()
        {
            Console.WriteLine("exercice 2 (elever au carré)");
            Console.WriteLine("nombre : ");
            int nbexo2 = int.Parse(Console.ReadLine());
            delg2 delegue2 = x => x * x; //expression lambda
            Console.WriteLine($"{nbexo2}² = { delegue2(nbexo2)}");
            Console.WriteLine("-----------------------------");
        }
        public void ExecuterExercice3()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("exercice 3(Implémenter un type anonyme qui comporte un ‘int', un ‘string)");
            var anonymeType = new { nombre = 6, chaine = "Romain" };
            Model.AfficherInfo(anonymeType);
            Console.WriteLine("-----------------------------");
        } 
        public void ExecuterExercice4()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("exercice 4 :allocation de mémoire");
            Model objA = new Model();
            Model objB = new Model();
            delg4 delegue4Simple = new delg4(objA.mA);
            delg4[] tabDelegue4 = new delg4[2];
            tabDelegue4[0] = new delg4(objA.mA);
            tabDelegue4[1] = new delg4(objB.mB);
            delg4 delegue4multicast = null;
            delegue4multicast += new delg4(objA.mA);
            delegue4multicast += new delg4(objB.mB);
            Console.WriteLine("-----------Allocation Normal------------------");
            objA.mA();
            objB.mB();
            Console.WriteLine("-----------Avec delegue simple------------------");
            delegue4Simple.Invoke();
            Console.WriteLine("-----------Avec delegue Tableau------------------");
            for (int i = 0; i < tabDelegue4.Length; i++)
            {
                tabDelegue4[i]();
            }
            Console.WriteLine("-----------Avec delegue multicast------------------");
            delegue4multicast.Invoke();
            Console.WriteLine("-----------on se désabonne de mb avec le multicast------------------");
            delegue4multicast -= new delg4(objB.mB);
            Console.WriteLine("-----------on (ré)invoke------------------");
            delegue4multicast.Invoke();
            Console.WriteLine("-----------------------------");
        }

        public void ExecuterExercice5()
        {
            Console.WriteLine("voir la corbeille d'exercice du prosit 4 la réponse est dedans !!!");
        }

        public void ExecuterExercice6()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("exercice 6");
            using (Model ressource = new Model())
            {
                Console.WriteLine("les actions sont simulées dans le using");
                Console.WriteLine($"exemple : ressource managée : {_modele._managedResource}; ressource non managée de type int  {_modele._unManagedResource}");
            }
            Console.WriteLine("-----------------------------");
        }

    }
}
