using System;



namespace DataLayer1

{
    public class Item
    {
        public string Description { get; set; }
        
        public Item(string description )
        {
            Description = description;
        }
    }
}