using UnityEngine;

public abstract class Item : MonoBehaviour
{
	[SerializeField] ParticleSystem _destroyEffectPrefab;

	public void Use(GameObject target)
	{
		InternalUse(target);

		if (_destroyEffectPrefab != null)
		{
			var effect = Instantiate(_destroyEffectPrefab);
			effect.transform.position = transform.position;
		}

		Destroy(gameObject);
	}

	public virtual void Take()
	{
		ResetPositionAndRotation();
	}

	private void ResetPositionAndRotation()
	{
		transform.localPosition = Vector3.zero;
		transform.rotation = Quaternion.identity;
	}

	protected abstract void InternalUse(GameObject target);
}