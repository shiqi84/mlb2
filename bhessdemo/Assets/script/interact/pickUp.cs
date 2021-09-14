using UnityEngine;

public class pickUp : interactable
{

	public item item;   


	public override void Interact()
	{
		base.Interact();

		PickUp();
	}

	
	void PickUp()
	{
		Debug.Log("Picking up " + item.name);
		Inventory.instance.addItem(item);
		Destroy(gameObject);   
	}

}