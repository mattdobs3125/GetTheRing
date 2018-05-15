using System;



namespace DataLayer1

{
    internal class Item
    {
        public string ItemDescription { get; set; }
        
        public Item(string itemdescription )
        {
            ItemDescription = itemdescription;
        }
    }
}