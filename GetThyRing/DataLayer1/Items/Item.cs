﻿using System;



namespace DataLayer1

{
    public class Item
    {
        public string ItemDescription { get; set; }
		public int Type { get; set; }
        
        public Item(string itemdescription, int type )
        {
            ItemDescription = itemdescription;
			Type = type;
        }
    }
}