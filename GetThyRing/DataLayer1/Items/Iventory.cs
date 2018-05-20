using System.Collections.Generic;
using DataLayer1.Interface;

namespace DataLayer1.Items
{
	public class Iventory
	{
		public string Des { get; set; }
		private List<Item> Items = new List<Item>();
		private List<IIventoryItem> PickedUpItem = new List<IIventoryItem>();

		public Iventory( string des)
		{
			Des = des;
		}
            



		internal void AddItem(IIventoryItem picked)
		{
			PickedUpItem.Add(picked);
		}
    }
}