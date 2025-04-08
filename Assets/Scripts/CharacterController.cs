using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	[SerializeField] private ItemInventory _inventory;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.F))
		{
			UseItem();
		}
	}

	private void UseItem()
	{
		if (!_inventory.TryTakeItem(out var item))
		{
			Debug.Log("Inventory is empty.");
			return;
		}

		item.Use(gameObject);
	}
}
