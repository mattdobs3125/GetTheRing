using System;
using System.Collections.Generic;
using System.Text;

namespace AppLayer.Menu
{
    public class MenuOption
    {
        public Action Choice { get; set; }
        public string Des { get; set; }
        public MenuOption(Action choice, string des)
        {
            Choice = choice;
			Des = des;
            
        }


    }
}
