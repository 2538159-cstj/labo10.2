using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo10._2
{
    internal class MenuePrincipale
    {
        public static ITrier votreChoix(int choix)
        {
            switch (choix)
            {
                case 1: return new Tri_bulles();
                case 2: return new Tri_Insertion();
                case 3: return new Tri_Selection();
                case 4: return new Tri_Rapide();
                case 5: return new Tri_Fusion();
                default:
                    Console.WriteLine("Choix invalide");
                    return null;

            }
        }
    }
}
