static class Game
{
    public static int score;
    public static bool dead;
    public static int currentMode;

    static int w = 25, h = 12;

    static List<Pos> snake;
    static List<Pos> food;
    static List<Pos> bombs;

    static Random rnd = new Random();

    static int dx = 1, dy = 0;

    public static void Init()
    {
        snake = new List<Pos> { new Pos(10, 5) };
        food = new List<Pos>();
        bombs = new List<Pos>();

        score = 0;
        dead = false;
    }

    public static void Update()
    {
        Input();

        Pos head = snake[0];
        Pos newHead = new Pos(head.x + dx, head.y + dy);

        Wrap(ref newHead);

        if (HitSelf(newHead)) dead = true;

        snake.Insert(0, newHead);

        SpawnFood();
        SpawnBombs();

        EatFood(newHead);
        HitBomb(newHead);

        snake.RemoveAt(snake.Count - 1);
    }

    static void Input()
    {
        if (!Console.KeyAvailable) return;

        var k = Console.ReadKey(true).Key;

        if (k == ConsoleKey.W) { dx = 0; dy = -1; }
        if (k == ConsoleKey.S) { dx = 0; dy = 1; }
        if (k == ConsoleKey.A) { dx = -1; dy = 0; }
        if (k == ConsoleKey.D) { dx = 1; dy = 0; }
    }

    public static void Draw()
    {
        Console.Clear();

        for (int y = 0; y < h; y++)
        {
            for (int x = 0; x < w; x++)
            {
                if (snake[0].x == x && snake[0].y == y)
                    Console.Write("O ");
                else if (Contains(snake, x, y))
                    Console.Write("o ");
                else if (Contains(food, x, y))
                    Console.Write("F ");
                else if (Contains(bombs, x, y))
                    Console.Write("B ");
                else
                    Console.Write(". ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nScore: " + score);
    }

    // =========================
    // ⚡ SPEED SYSTEM
    // =========================
    public static int GetSpeed()
    {
        return Math.Max(50, 200 - score);
    }

    // =========================
    // 🍎 FOOD
    // =========================
    static void SpawnFood()
    {
        while (food.Count < 3)
            food.Add(new Pos(rnd.Next(w), rnd.Next(h)));
    }

    static void EatFood(Pos p)
    {
        for (int i = 0; i < food.Count; i++)
        {
            if (food[i].x == p.x && food[i].y == p.y)
            {
                food.RemoveAt(i);
                score += 10;
            }
        }
    }

    // =========================
    // 💣 BOMBS
    // =========================
    static void SpawnBombs()
    {
        if (currentMode != 1) return;

        while (bombs.Count < 2)
            bombs.Add(new Pos(rnd.Next(w), rnd.Next(h)));
    }

    static void HitBomb(Pos p)
    {
        foreach (var b in bombs)
            if (b.x == p.x && b.y == p.y)
                dead = true;
    }

    // =========================
    // 🧠 COLLISION
    // =========================
    static bool HitSelf(Pos p)
    {
        foreach (var s in snake)
            if (s.x == p.x && s.y == p.y)
                return true;
        return false;
    }

    static void Wrap(ref Pos p)
    {
        if (p.x < 0) p.x = w - 1;
        if (p.x >= w) p.x = 0;
        if (p.y < 0) p.y = h - 1;
        if (p.y >= h) p.y = 0;
    }

    static bool Contains(List<Pos> list, int x, int y)
    {
        foreach (var p in list)
            if (p.x == x && p.y == y)
                return true;
        return false;
    }

    class Pos
    {
        public int x, y;
        public Pos(int x, int y) { this.x = x; this.y = y; }
    }
}