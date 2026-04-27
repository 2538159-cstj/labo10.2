using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo10._2
{
    internal class Tri_Selection : ITrier
    {
        //Trouve le plus petit élément de la liste et le place au début
        //puis continue avec le reste de la liste 

        public List<int> Trier(List<int> liste)
        {
            var resultat = new List<int>(liste);
            for (int i = 0; i < resultat.Count; i++)
            {
                int minimumIndex = i;
                for (int j = i + 1; j < resultat.Count; j++)
                {
                    if (resultat[j] < resultat[minimumIndex])
                    {
                        minimumIndex = j;
                    }
                }
                (resultat[i], resultat[minimumIndex]) = (resultat[minimumIndex], resultat[i]);
            }
            return resultat;
        }
          
    }

}
