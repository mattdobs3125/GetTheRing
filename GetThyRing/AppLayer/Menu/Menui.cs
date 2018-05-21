using System;
using System.Collections.Generic;
using System.Text;

namespace AppLayer.Menu
{
    public class Menui
    {
        private string Name { get; set; }
        private List <MenuOption>  Options { get; set; }
        public Menui(string name , List<MenuOption>options)
        {
            Name = name;
            Options = options;
        }
		void PrintGameOption(){
			int count = 1;
			foreach (var options in Options ){
				Console.WriteLine($"{count++} {options.Des}");
			}
		}

		public Action Select()
		{
			PrintGameOption();
			string input = Console.ReadLine();
			int index = -1;
			bool check = Int32.TryParse(input, out index);
			if (!check || index<=0 || index >Options.Count)
			{

				Console.Clear();
				Console.WriteLine("I dont know {0}",input);
				return null;

			}
			Console.Clear();
			return Options[index - 1].Choose;
		}
	
	
	
	
	}

}
