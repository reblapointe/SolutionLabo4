namespace SolutionLabo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 16;

            bool valide;
            int taille;
            char bordure;
            char centre;
            do
            {
                Console.WriteLine($"Entrez un nombre entre {MIN} et {MAX}");
                valide = int.TryParse(Console.ReadLine(), out taille);
            } while (!valide || taille < MIN || taille > MAX);

            Console.WriteLine("\nEntrez le caractère de la bordure");
            bordure = Console.ReadKey().KeyChar;
            do
            {
                Console.WriteLine("\nEntrez un caractère différent pour le centre");
                centre = Console.ReadKey().KeyChar;
            } while (bordure == centre);

            Console.Write("\n");
            for (int rangee = 0; rangee < taille; rangee++)
            {
                for (int colonne = 0; colonne < taille; colonne++)
                {
                    if (rangee == 0 || colonne == 0 || rangee == taille - 1 || colonne == taille - 1)
                    {
                        Console.Write(bordure);
                    }
                    else
                    {
                        Console.Write(centre);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}