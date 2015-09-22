using UnityEngine;
using System.Collections;

/**
* ...
* @author Niek Schoone
**/

public class UziWeapon : Weapon 
{

	public override void Shoot()
	{
		Debug.Log ("Fire");

		rate = 0.1f;

		accuracyRange = 5;
		finalAccuracy = Random.Range(-accuracyRange, accuracyRange);

		Vector2 shootDirection = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
		shootDirection = shootDirection-new Vector2(baseWeapon.transform.position.x, baseWeapon.transform.position.y);
		float angle = Mathf.Atan2(shootDirection.y,shootDirection.x) * Mathf.Rad2Deg - 90;
		
		GameObject newBullet = Instantiate(bulletPrefab, new Vector2(baseWeapon.transform.position.x, baseWeapon.transform.position.y) + (shootDirection.normalized / 2), Quaternion.Euler(0,0,angle + finalAccuracy)) as GameObject;
		Camera.main.GetComponent<CameraShake>().Shake(0.001f, 0.002f);
	}
	
	public override void Update()
	{
		rate -= Time.deltaTime;
		if(rate <= 0)
		{
			if(Input.GetMouseButton(0))
			{
				Shoot();
			}
		}
	}
}
