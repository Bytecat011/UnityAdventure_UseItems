using UnityEngine;

public class HealthModifierItem : Item
{
	[SerializeField] private int _modifierValue;

	protected override void InternalUse(GameObject target)
	{
		var health = target.GetComponent<Health>();
		if (health != null)
		{
			health.Add(_modifierValue);
			Debug.Log($"Current health: {health.CurrentHealth}");
		}
	}
}