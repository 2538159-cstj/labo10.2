namespace labo10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisir la liste ");
            var donnees = Console.ReadLine();

            var data =donnees.Split(' ').Select(int.Parse).ToList();

            //Chaine de caractère avec des espaces comme séparateur 

            Console.WriteLine("1. Tri bulle");
            Console.WriteLine("2. Tri Insertion");
            Console.WriteLine("3. Tri Selection");
            Console.WriteLine("4. Tri Rapide");
            Console.WriteLine("5. Tri Fusion");

            Console.WriteLine("Votre choix? (1-5) : ");
            int choix = int.Parse(Console.ReadLine());

            ITrier algo = MenuePrincipale.votreChoix(choix);
            List<int> listeTrier = algo.trier(data);
            Console.WriteLine("Liste triée");
            Console.WriteLine(string.Join(" ",listeTrier));

        }
    }
}
