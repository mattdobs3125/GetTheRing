﻿using DataLayer1.PRoviders;

using AppLayer.Menu;
using System.Collections.Generic;
using System;

namespace GetThyRing
{
    public class GameService
    {
        private Menui MainMenu { get; set; }
        private Menui GameMenu { get; set; }
        private GameProvider _GameP = new GameProvider();
        private int _itemiD { get; set; }
        private bool GamePlaying { get; set; }

        public bool Running { get;  set; }


        public GameService()
        {

            Running = true;
            GamePlaying = true;

            MainMenu = BuildMainMenu();
        }
            
#region MainMenu      
               Menui BuildMainMenu()
        {
            return new Menui("Game Main Menu", new List<MenuOption>
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
         void BuildGameMenu()
        {
             GameMenu =new Menui("Game Main Menu", new List<MenuOption>
            {
                new MenuOption (FirstLevel,"YourHEREADVBERGQWFRWG"),

                new MenuOption (ExitGame, "Close the Game")

            });
        }                                                  
        public void GameMenuSelection(){
            Action action = GameMenu.Select();
            if (action != null){
                action.Invoke();
            }
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
        
            
       



    }
}