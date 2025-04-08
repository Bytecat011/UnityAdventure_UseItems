using UnityEngine;

public class LaunchProjectileItem : Item
{
	[SerializeField] private Projectile _projectilePrefab;

	public override void Take()
	{
		base.Take();
		DisableAnimationComponents();
	}

	private void DisableAnimationComponents()
	{
		GetComponent<SinMotionAnimation>().enabled = false;
		GetComponent<ItemRotator>().enabled = false;
	}

	protected override void InternalUse(GameObject target)
	{
		var projectile = Instantiate(_projectilePrefab);
		projectile.transform.position = transform.position;
		projectile.Launch(target.transform.forward);
	}
}