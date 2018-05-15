using System;


namespace GetThyRing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			GameService play = new GameService();
			while (play.Running){
				play.GameService();
			}

            
            
            
        }
    }
}
