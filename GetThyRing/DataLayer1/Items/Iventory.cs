using System;
using System.Collections.Generic;
using DataLayer1.Interface;

namespace DataLayer1.Items
{
	public abstract class Iventory : IIventoryItem
	{
		public string Des { get; set; }
		public string Identify { get; set; }
		public string Title { get; set; }


		private List<Item> PickedUpItem = new List<Item>();

		public Iventory(string des)
		{
			Des = des;
		}
		internal void AddItem(Item picked)
		{
			PickedUpItem.Add(picked);
		}
		public void ShowIventory()
		{
			foreach (var o in PickedUpItem)
			{
				if (PickedUpItem.Capacity == -1)
				{
					Console.WriteLine("Theres nothing in the bag");
				}
				Console.WriteLine($"{o}");
			}
		}
	}
            
            
}