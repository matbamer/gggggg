Main(); static void Main()
{
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Z)
        {
            Ga();
        }
        if (key.Key == ConsoleKey.X)
        {
            Gb();
        }
        if (key.Key == ConsoleKey.C)
        {
            Gc();
        }
        if (key.Key == ConsoleKey.Escape)
        {
            break;
        }
    }
}

static void Ga()
{
    int[] Octave = new int[] { 261, 293, 329, 349, 392, 440, 493, 277, 311, 369, 415, 466 }; 
    Note(Octave);
}

static void Gb()
{
    int[] Octave = new int[] { 523, 587, 659, 698, 784, 880, 987, 554, 622, 739, 830, 932 };
    Note(Octave);
}

static void Gc()
{
    int[] Octave = new int[] { 1046, 1174, 1318, 1396, 1568, 1720, 1975, 1108, 1244, 1480, 1661, 1864 };
    Note(Octave);
}


static void Note(int[] Octave)
{
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        Console.Clear(); switch (key.Key)
        {
            case ConsoleKey.A:
                BOP(Octave[0]);
                break;
            case ConsoleKey.S:
                BOP(Octave[1]);
                break;
            case ConsoleKey.D:
                BOP(Octave[2]);
                break;
            case ConsoleKey.F:
                BOP(Octave[3]);
                break;
            case ConsoleKey.G:
                BOP(Octave[4]);
                break;
            case ConsoleKey.H:
                BOP(Octave[5]);
                break;
            case ConsoleKey.J:
                BOP(Octave[6]);
                break;
            case ConsoleKey.W:
                BOP(Octave[7]);
                break;
            case ConsoleKey.E:
                BOP(Octave[8]);
                break;
            case ConsoleKey.R:
                BOP(Octave[9]);
                break;
            case ConsoleKey.T:
                BOP(Octave[10]);
                break;
            case ConsoleKey.Y:
                BOP(Octave[11]);
                break;

            case ConsoleKey.Backspace:
                Main();
                break;
            case ConsoleKey.Escape:
                Environment.Exit(0); break;
        }
    }
}
static void BOP(int chastota)
{
    Console.Beep(chastota, 500); Console.Clear();
}