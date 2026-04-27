using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo10._2
{
    internal class Tri_bulles : ITrier
    {
        //Compare les éléments adjascents et les échanges s'ils sont dans le mauvais ordre
        //Repère ce processus jusqu'à ce que la list soit triée

        public List<int> Trier(List<int> liste)
        {
            var resultat = new List<int>(liste);
            for (int i = 0; i < resultat.Count; i++)
            {
                for (int j = 0; j < resultat.Count - i - 1; j++)
                {
                    if (resultat[j] > resultat[j + 1])
                    {
                        (resultat[j], resultat[j + 1]) = (resultat[j + 1], resultat[j]);
                        //affectation tuplet, qui equivaut à

                        //int temp = resultat[j]
                        //(resultat[j], resultat[j + 1])
                        //resultat[j+1]=temps
                    }
                }
            }
            return resultat;
        }
    }
}
