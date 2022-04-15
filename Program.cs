using System;

namespace GameProject5
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new BlockGame())
                game.Run();
        }
    }
}
