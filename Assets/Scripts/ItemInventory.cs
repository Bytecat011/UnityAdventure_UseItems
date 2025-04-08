using System.Collections.Generic;
using UnityEngine;

public class ItemInventory : MonoBehaviour
{
	[SerializeField] private int _itemsLimit = 1;

	private Queue<Item> _storedItems = new Queue<Item>();

	public bool TryAddItem(Item item)
	{
		if (_storedItems.Count >= _itemsLimit)
		{
			return false;
		}

		_storedItems.Enqueue(item);
		return true;
	}

	public bool TryTakeItem(out Item item)
	{
		item = null;
		if (_storedItems.Count == 0)
		{
			return false;
		}

		item = _storedItems.Dequeue();
		return true;
	}
}
