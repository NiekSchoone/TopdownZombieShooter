using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Weapons : MonoBehaviour 
{
	public Dictionary<WeaponType, WeaponTest> weaponList = new Dictionary<WeaponType, WeaponTest>();

	void Start () 
	{
		//weaponList.Add(WeaponType.Pistol, new Pistol());
		//weaponList[WeaponType.Pistol].Shoot();
		Debug.Log(weaponList.Count);
	}
	
	void Update () 
	{
	
	}
}

public abstract class WeaponTest : MonoBehaviour
{
	protected string name = "name";
	[SerializeField]
	protected GameObject bullet;

	public abstract void Shoot();
}

public class Pistol : WeaponTest
{
	public override void Shoot()
	{
		//GameObject newBullet = Instantiate(bullet);
	}
}
