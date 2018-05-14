using System;



namespace DataLayer1

{
    public class Item
    {
        public string ItemDescription { get; set; }
        
        public Item(string itemdescription )
        {
            ItemDescription = itemdescription;
        }
    }
}