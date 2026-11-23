namespace beugro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> napiLatogatokSzama = new List<int>() { 15, 68, 77, 67 };

            foreach (int latogatok in napiLatogatokSzama)
            {
                Console.WriteLine(latogatok);
            }

            //Hány szám van a listában

            int counter = napiLatogatokSzama.Count;
            Console.WriteLine(counter);

            //Elemek kitörlése a listából

            napiLatogatokSzama.Remove(68);

            //berakja a 100-at a 2. helyre a listában

            napiLatogatokSzama.Insert(1, 100);

            //sorrendbe rakja a listát

            napiLatogatokSzama.Sort();

            //keresi a 100-at a listában és visszaadja az indexét

            napiLatogatokSzama.IndexOf(100);

            //megforditja a listát

            napiLatogatokSzama.Reverse();

            //törli az összes elemet a listából

            napiLatogatokSzama.Clear();
        }
    }
}
