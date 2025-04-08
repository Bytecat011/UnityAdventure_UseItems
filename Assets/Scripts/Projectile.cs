using UnityEngine;

public class Projectile : MonoBehaviour
{
	[SerializeField] float _speed = 10;
	[SerializeField] float _lifetime = 1;

	private float _remainDuration = 0;

	public void Launch(Vector3 direction)
	{
		transform.rotation = Quaternion.LookRotation(direction);
		_remainDuration = _lifetime;
	}

	private void Update()
	{
		transform.Translate(Vector3.forward * _speed * Time.deltaTime, Space.Self);
		_remainDuration -= Time.deltaTime;

		if (_remainDuration < 0f)
		{
			Destroy(gameObject);
		}
	}
}
