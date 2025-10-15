namespace EgzaminProbny1ConsoleApp
{
    internal class Program
    {
        static int[] tablica = new int[51];
        static Random rand = new Random();
        //******************
        //Nazwa funkcji: sortuj
        //parametry wejściowe: tablica typu int[]
        //informacje: funkcja sortuje tablicę
        //zwracany typ: int[]
        //Autor: Bartosz Semczuk
        //******************
        static int[] sortuj(int[] tablica)
        {
            int[] posortowanaTablica = new int[51];
            for(int i = tablica.Length-1; i>=1; i--)
            {
        
                posortowanaTablica[i] = tablica[znajdźMax(tablica)];
                tablica[znajdźMax(tablica)] = 0;
            }
            return posortowanaTablica;
            
        }
        //******************
        //Nazwa funkcji: znajdźMax
        //parametry wejściowe: tablica typu int[]
        //informacje: funkcja znajduje maksymalny element w tablicy
        //zwracany typ: int[]
        //Autor: Bartosz Semczuk
        //******************
        static int znajdźMax(int[] tablica)
        {
            int max = 1;
            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] > tablica[max])
                {
                    max = i;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < tablica.Length; i++)
            {
                tablica[i] = rand.Next(0, 101);
            }
            Console.WriteLine("Tablica nieposortowana: ");
            for (int i = 1; i < tablica.Length; i++)
            {
                Console.WriteLine("Pozycja w tablicy: " + (i) + " wartość: " + tablica[i]);
            }

            Console.WriteLine("Max: " + tablica[znajdźMax(tablica)]);

            int[] posortowanaTablica = sortuj(tablica);
            Console.WriteLine("Tablica posortowana: ");
            for (int i = 1; i < posortowanaTablica.Length; i++)
            {
                Console.WriteLine("Pozycja w tablicy: " + i + " wartość: " + posortowanaTablica[i]);
            }

        }
    }
}
