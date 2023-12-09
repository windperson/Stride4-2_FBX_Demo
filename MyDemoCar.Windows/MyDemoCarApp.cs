using Stride.Engine;

namespace MyDemoCar
{
    class MyDemoCarApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
