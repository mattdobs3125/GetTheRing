using System;
using System.Collections.Generic;
using DataLayer1.Items;

namespace DataLayer1.Items
{
    internal abstract class PickedUpItem
    {
        public PickedUpItem()
        {
		}
		public int type { get; set; }
		public List<Iventory> Iventories { get; set; }
        

		public void Pickedup (){
			         

		}


    }
}
