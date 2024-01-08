namespace Pianino
{
    internal class Program
    {
        public static void Main()
        {
            ConsoleKeyInfo Key;
            do
            {
                Key = Console.ReadKey(true);
                if (Key.Key == ConsoleKey.F5)
                {
                    Octaves(Key);
                }
                else if (Key.Key == ConsoleKey.F6) { Octaves(Key); }
                Octaves(Key);
                PlaySound(Key);
            }
            while (Key.Key != ConsoleKey.Escape);
        }

        public static int[] Octaves(ConsoleKeyInfo Key)
        {
            int[] ThirdOctave = new int[12] { 65, 69, 73, 78, 82, 87, 93, 98, 104, 110, 117, 124};
            int[] FourthOctave = new int[12] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247};
            int[] y = ThirdOctave;
            if (Key.Key == ConsoleKey.F3)
            {
                y = ThirdOctave;
            }
            if (Key.Key == ConsoleKey.F4)
            {
                y = FourthOctave;
            }
            return y;
        }

        static void PlaySound(ConsoleKeyInfo Key)
        {
            int[] oct = Octaves(Key);
            if (Key.Key == ConsoleKey.Q)
            {
                Console.Beep(oct[0], 300);
            }
            if (Key.Key == ConsoleKey.W)
            {
                Console.Beep(oct[1], 300);
            }
            if (Key.Key == ConsoleKey.E)
            {
                Console.Beep(oct[2], 300);
            }
            if (Key.Key == ConsoleKey.R)
            {
                Console.Beep(oct[3], 300);
            }
            if (Key.Key == ConsoleKey.T)
            {
                Console.Beep(oct[4], 300);
            }
            if (Key.Key == ConsoleKey.Y)
            {
                Console.Beep(oct[5], 300);
            }
            if (Key.Key == ConsoleKey.A)
            {
                Console.Beep(oct[6], 300);
            }
            if (Key.Key == ConsoleKey.S)
            {
                Console.Beep(oct[7], 300);
            }
            if (Key.Key == ConsoleKey.D)
            {
                Console.Beep(oct[8], 300);
            }
            if (Key.Key == ConsoleKey.F)
            {
                Console.Beep(oct[9], 300);
            }
            if (Key.Key == ConsoleKey.G)
            {
                Console.Beep(oct[10], 300);
            }
            if (Key.Key == ConsoleKey.H)
            {
                Console.Beep(oct[11], 300);
            }
        }
    }
}