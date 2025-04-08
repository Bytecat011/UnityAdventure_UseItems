using UnityEngine;

public class ItemCollector : MonoBehaviour
{
	[SerializeField] private ItemInventory _inventory;
	[SerializeField] private Transform _storeItemPoint;

	private void OnTriggerEnter(Collider other)
	{
		var item = other.GetComponent<Item>();

		if (item == null)
			return;

		if (!_inventory.TryAddItem(item))
		{
			Debug.Log("I can't take the item. Inventory is full.");
			return;
		}

		item.transform.SetParent(_storeItemPoint, false);
		item.Take();
	}
}
