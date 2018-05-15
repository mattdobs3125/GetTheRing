using System;
namespace DataLayer1.Interface
{
    public interface IPickupAble
    {
	    
		Action Pickup { get; set; }
	    string PickupAble();

	}


    public class Canpickup{
        public IPickupAble c { get; set; }
        public string TryToPickUp(){
            c.PickupAble();
        }
    }







}

