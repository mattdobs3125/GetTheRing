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
		public bool Runinng { get; private set; }

		public GameService()
		{

			Runinng = true;
			GamePlaying = false;
			Pausecc = false;

		}
		void BuildGameMenu()
		{
			GameMenu = new Menui("Game Menu", new List<MenuOption>
			{
				new MenuOption (PlayGame,"Find The Ring")
			});



		}

		private void PlayGame()
		{
			throw new NotImplementedException();
		}


	}
}