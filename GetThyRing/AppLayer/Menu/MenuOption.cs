﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppLayer.Menu
{
    public class MenuOption
    {
        public Action Choose { get; set; }
        public string Des { get; set; }
        public MenuOption(Action choose, string des)
        {
            Choose = choose;
			Des = des;
            
        }


    }
}
