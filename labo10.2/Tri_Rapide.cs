using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo10._2
{
    internal class Tri_Rapide : ITrier
    {
        //choisi un pivot, partitionne les éléments autour de ce pivot et trie recursivement
        public List<int> Trier(List<int> liste)
        {
            var resultat = new List<int>(liste);
            Trie_Rapide(resultat, 0, resultat.Count - 1);
            return resultat;
        }
        private void Trie_Rapide(List<int> resultat, int gauche, int droite)
        {
            if(gauche < droite)
            {
                int pivotIndex = Partitioner(resultat, gauche, droite);
                Trie_Rapide(resultat, gauche, pivotIndex - 1);//recursivité 
                Trie_Rapide(resultat, pivotIndex + 1, droite);
            }
        }
        private int Partitioner(List<int> resultat, int gauche, int droite)
        {
            int pivot = resultat[droite];
            int i = gauche - 1;
            for (int j = gauche; j < droite; j++)
            {

                if (resultat[j] < pivot)
                {
                    i++;
                    (resultat[j], resultat[j]) = (resultat[j], resultat[i]);
                }
            }
            (resultat[i + 1], resultat[droite]) = (resultat[droite], resultat[i + 1]);
            return i + 1;
        }
    }
}
