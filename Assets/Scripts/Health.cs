using UnityEngine;

public class Health : MonoBehaviour
{
	[SerializeField] private int _startHealth = 100;

	private int _health;

	public int CurrentHealth => _health;

	private void Awake()
	{
		_health = _startHealth;
	}

	public void Add(int value)
	{
		_health += value;

		if (_health < 0)
		{
			_health = 0;
		}
	}
}
