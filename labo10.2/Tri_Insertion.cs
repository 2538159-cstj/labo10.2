using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo10._2
{
    internal class Tri_Insertion :ITrier
    {
        //Insere chaque elements à sa place dans une sous liste déja triée 
        public List<int> Trier(List<int> liste)
        {
            var resultat = new List<int>(liste);
            for (int i = 0; i < resultat.Count; i++)
            {
                int cle = resultat[i];
                int j = i - 1;
                while(j >= 0 && resultat[j] > cle)
                {
                    resultat[j + 1] = resultat[j];
                    j--;
                }
                resultat[j + 1] = cle;
            }
            return resultat;
        }
    }
}
