using UnityEngine;
using System.Collections;

/**
* ...
* @author Niek Schoone
**/

public abstract class Weapon : ScriptableObject 
{
	public float damage;
	public float ammo;
	public float rate;

	public float accuracyRange;
	public float finalAccuracy;

	public Sprite look;

	public Transform baseWeapon;

	public GameObject bulletPrefab;
	public GameObject audioManager;

	public abstract void Shoot();
	public abstract void Update();
	
}
