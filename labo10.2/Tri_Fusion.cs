using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo10._2
{
    internal class Tri_Fusion : ITrier
    {
        //Divise la liste en deux, trie chaque moitié puis fusioinne les resultats 
        public List<int> Trier(List<int> liste)
        {
            if (liste.Count <= 1)
            {
                return liste;
            }
            int milieu = liste.Count / 2; //Trouver le milieu de la liste 

            var gauche = Trier(liste.GetRange(0, milieu));//Retourne la sous liste à partir de l'indice de départ (0) et d'une longueur (milieu)
            var droite = Trier(liste.GetRange(milieu, liste.Count - milieu));

            return FusionListe(gauche, droite);
        }
        public List<int> FusionListe (List<int> gauche, List<int>droite)
        {
            var resultat = new List<int>();
            int i = 0; int j = 0;

            while(i < gauche.Count && j < droite.Count)
            {
                
                    if (gauche[1] <= droite[j])
                        resultat.Add(gauche[i++]);
                    else
                        resultat.Add(droite[j++]);
            }
            resultat.AddRange(gauche.Skip(i));
            resultat.AddRange(gauche.Skip(j));
            return resultat;
            //AddRange() : ajoute plusieurs éléments à la suite de la liste résultats
            //Contrairement à la méthode  Add() qui ajoute un seul élément a la liste

            //Skip(i) : Méthode qui ignore les "i" premiers éléments de la liste et retourne le retse 
        }
















    }
}
