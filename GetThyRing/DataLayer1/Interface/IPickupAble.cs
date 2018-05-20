using System;
namespace DataLayer1.Interface
{
	public interface IPickupAble
	{

		void PickUp(IIventoryItem IventoryItem, string choose = "");
		void Drop(IIventoryItem IventoryItem, string choose = "");

	}
}
