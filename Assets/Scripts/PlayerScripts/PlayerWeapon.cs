using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/**
* ...
* @author Niek Schoone
**/

public class PlayerWeapon : MonoBehaviour 
{
	public Weapon[] weaponAssigning = new Weapon[3];
	public Dictionary<WeaponType, Weapon> weapons = new Dictionary<WeaponType, Weapon>();

	private Transform weaponBase;

	public GameObject getAudioManager;

	public WeaponType currentWeapon = WeaponType.PISTOL;

	void Start () 
	{
		weaponBase = this.transform;

		weapons.Add(WeaponType.PISTOL, weaponAssigning[0]);
		weapons.Add(WeaponType.UZI, weaponAssigning[1]);
		weapons.Add(WeaponType.SHOTGUN, weaponAssigning[2]);

		for (int i = 0; i < weapons.Count; i++)
		{
			weaponAssigning[i].baseWeapon = weaponBase;
		}
	}

	void Update()
	{
		weapons[WeaponType.PISTOL].Update();
	}
}

public enum WeaponType
{
	PISTOL,
	UZI,
	SHOTGUN
}