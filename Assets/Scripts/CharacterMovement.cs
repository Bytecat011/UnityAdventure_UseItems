using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
	private static string HorizontalAxis = "Horizontal";
	private static string VerticalAxis = "Vertical";

	[SerializeField] private float _movementSpeed;
	[SerializeField] private float _rotarionSpeed;

	private void Update()
	{
		float xMove = Input.GetAxis(HorizontalAxis);
		float yMove = Input.GetAxis(VerticalAxis);

		Vector3 movementDirection = new Vector3(xMove, 0, yMove).normalized;

		if (movementDirection.sqrMagnitude > 0)
		{
			transform.position += _movementSpeed * movementDirection * Time.deltaTime;
			ProcessRotateTo(movementDirection);
		}
	}

	private void ProcessRotateTo(Vector3 direction)
	{
		Quaternion lookRotation = Quaternion.LookRotation(direction);
		float step = _rotarionSpeed * Time.deltaTime;
		transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
	}

	public void ChangeSpeed(float modifier)
	{
		_movementSpeed += modifier;
		if (_movementSpeed < 0f)
		{
			_movementSpeed = 0f;
		}
	}
}
