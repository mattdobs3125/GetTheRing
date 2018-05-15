using DataLayer1.PRoviders;

using AppLayer.Menu;
using System.Collections.Generic;
using System;

namespace GetThyRing
{
	public class GameService
	{
		private Menui GameMenu { get; set; }
		private GameProvider _GameP = new GameProvider();
		private int _itemiD { get; set; }
		private bool GamePlaying { get; set; }
		private bool Pausecc { get; set; }
		public bool Running { get; private set; }


		public GameService()
		{

			Running = true;
			GamePlaying = false;
			Pausecc = false;
			BuildGameMenu();
            


		}
		public void BuildGameMenu()
		{
			GameMenu = new Menui("Game Main Menu", new List<MenuOption>
			{
				new MenuOption (FirstLevel,"Find The Ring"),
                new MenuOption (ExitGame, "Close the Game")
			});

            

		}

		private void ExitGame()
		{
			Console.WriteLine("You've closed the program");
			Running = false;
		}

		private void FirstLevel()
		{
			Console.Clear();
            Console.WriteLine("Your in room, it's quiet and cold.  ");



		}


	}
}