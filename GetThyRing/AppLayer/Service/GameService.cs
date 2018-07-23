using DataLayer1.PRoviders;

using AppLayer.Menu;
using System.Collections.Generic;
using System;
using DataLayer1.Items;
using DataLayer1;

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
				//new MenuOption (Blank, @"                              
                


                                          


                                                                                 //"),
                new MenuOption (AddSword, "Enter 3 to Add the Mighty Sword to your inventory 2"),
                new MenuOption (ShowIventory, "Enter 4 to open your Iventory"),
                new MenuOption (ExitGame, "Close the Game")

            });
        }

        private void AddSword()
        {
            
        }

        public void GameMenuSelection(){
			GamePlaying = true;
			while(GamePlaying){Action choose = GameMenu.Select();
				if (choose != null)
				{
					choose.Invoke();
				}}
			
		}

		#endregion
        public List<Item> PickedUpItem = new List<Item>(); 
        public List<Item> P = new List<Item>();
        public void ShowIventory()
        {
			foreach (var o in PickedUpItem)
			{
                if (PickedUpItem.Count == P.Count)
				{
					Console.WriteLine("Theres nothing in the bag");
				}
				else
				{
					Console.WriteLine(o);
				}
			}
		}
                    



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