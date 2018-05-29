﻿using DataLayer1.PRoviders;

using AppLayer.Menu;
using System.Collections.Generic;
using System;
using DataLayer1.Items;

namespace GetThyRing
{
    public class GameService
    {
        private Menui MainMenu { get; set; }
        private Menui GameMenu { get; set; }
		private Menui SecondLevel { get; set; }
		private Iventory _Inven { get; set; }
        private GameProvider _GameP = new GameProvider();
        private int _itemiD { get; set; }
        private bool GamePlaying { get; set; }
        
        public bool Running { get;  set; }


        public GameService()
        {
            
            Running = true;
            GamePlaying = true;

            MainMenu = BuildMainMenu();
			GameMenu = BuildGameMenu();
			SecondLevel = BuildSecondLevel();
        }
            
#region MainMenu      
               Menui BuildMainMenu()
        {
            return new Menui( new List<MenuOption>
            {
                new MenuOption (GameMenuSelection,"Find The Ring"),
                
                new MenuOption (ExitGame, "Close the Game")

            });
        }
        public void MainMenuSelection()
        {
            Console.Clear();
            Action choose = MainMenu.Select();
            if (choose!= null )
            {
                choose.Invoke();
            }
        }
		#endregion
#region FirstLevel Menu
		Menui BuildGameMenu()
        {
             return new Menui( new List<MenuOption>
            {
				new MenuOption (FirstLevel,"Your in room, it's quiet and cold.Theres a Sword and a Ring on the table "),
				new MenuOption (Blank, @"                              
                


                                          


                                                                                 "),
				//new MenuOption (_Inven.ShowIventory , "Enter 3 to open your Iventory"),
                new MenuOption (ExitGame, "Close the Game")

            });
        }

  //      public void LookAtInventory() 
		//{
		//	LookAtIventory = _Inven.ShowIventory();
			
		//}

		public void GameMenuSelection(){
			GamePlaying = true;
			while(GamePlaying){Action choose = GameMenu.Select();
                if (choose != null)
                {
                    choose.Invoke();
                }}
            
        }

		#endregion
		Menui BuildSecondLevel()
		{
			return new Menui(new List<MenuOption>
			{
				new MenuOption(Blank,"nothing")
			});
		}
		public void SecondLevelSelect(){
			
		}

        private void ExitGame()
        {
            GamePlaying = false;
            Console.WriteLine("You've closed the program");
            Console.Clear();
        }

        private void FirstLevel()
        {
            Console.Clear();
            Console.WriteLine("Your in room, it's quiet and cold.  ");
        }
        
		private void Blank(){
			Console.WriteLine("g");
		}     
       



    }
}