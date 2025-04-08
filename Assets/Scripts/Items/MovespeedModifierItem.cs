using UnityEngine;

public class MovespeedModifierItem : Item
{
	[SerializeField] private float _modifierValue;

	protected override void InternalUse(GameObject target)
	{
		var characterMovement = target.GetComponent<CharacterMovement>();
		if (characterMovement != null)
		{
			characterMovement.ChangeSpeed(_modifierValue);
		}
	}
}
