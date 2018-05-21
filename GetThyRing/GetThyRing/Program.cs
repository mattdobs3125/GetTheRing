using System;
using AppLayer;

namespace GetThyRing
{
    class Program
    {
        static void Main(string[] args)
        {
            
			GameService play = new GameService();

			while (play.Running){
				play.LevelSelection();
               
			}
           

			       


            
            
            
        }
    }
}
