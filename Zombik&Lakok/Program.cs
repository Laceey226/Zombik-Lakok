namespace Zombik_Lakok
{
    internal class Program
    {
        static Random random = new Random();
        static string[] Nevkiosztas(int elemekSzama)
        {
            string[] nevek = { "Péter", "Anna", "Bence", "Eszter", "Dávid", "Réka", "Gábor", "Zsófia",
                "Tamás", "Lilla", "Márk", "Dóra", "Ádám", "Nóra", "Levente", "Balázs", "Kata", "Máté",
                "Viktória", "András" };
            string[] tomb = new string[elemekSzama];
            for (int i = 0; i < elemekSzama; i++)
            {
                int index = random.Next(0, nevek.Length);
                tomb[i] = nevek[index];
            }
            return tomb;
        }
        static void Kiir(string[] tomb)
        {
            foreach (var item in tomb)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string[] lakossag = Nevkiosztas(6);
            Kiir(lakossag);
        }
    }
}
