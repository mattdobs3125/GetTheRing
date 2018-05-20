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

		public bool Running { get;  set; }


		public GameService()
		{
            
			Running = true;
			GamePlaying = true;

			GameMenu = BuildGameMenu();
		}
            
        

	   public Menui BuildGameMenu()
		{
			return new Menui("Game Main Menu", new List<MenuOption>
			{
				new MenuOption (FirstLevel,"Find The Ring"),
				new MenuOption (ExitGame, "Close the Game")

			});
		}

		void BuildFirstLevelMenu()
		{
			
		}    


		private void ExitGame()
		{
			Console.WriteLine("You've closed the program");
			GamePlaying = false;
		}

		private void FirstLevel()
		{
			Console.Clear();
            Console.WriteLine("Your in room, it's quiet and cold.  ");
		}

        public void LevelSelection ()
		{
			

				Action action = GameMenu.Select();
				if (action!= null )
				{
					action.Invoke();
				}
		
		}



	}
}