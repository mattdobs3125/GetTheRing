using System;
using System.Collections.Generic;
using System.Text;

namespace AppLayer.Menu
{
    class Menui
    {
        private string Name { get; set; }
        public List <MenuOption>  Options { get; set; }
        public Menui(string name , List<MenuOption>options)
        {
            Name = name;
            Options = options;
        }
    }
}
