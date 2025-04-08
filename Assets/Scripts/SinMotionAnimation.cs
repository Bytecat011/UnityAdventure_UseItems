using UnityEngine;

public class SinMotionAnimation : MonoBehaviour
{
	[SerializeField] private float _offset;
	[SerializeField] private float _speed;

	private float _startYPosition;

	private void Awake()
	{
		_startYPosition = transform.localPosition.y;
	}

	private void Update()
	{
		Vector2 position = transform.localPosition;
		position.y = _startYPosition + _offset * Mathf.Sin(position.x + _speed * Time.time);
		transform.localPosition = position;
	}
}
