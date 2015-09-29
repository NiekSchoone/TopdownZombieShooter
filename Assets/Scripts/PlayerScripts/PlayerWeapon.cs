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
	private SpriteRenderer sprtRenderer;
	private Sprite currentSprite;

	public GameObject getAudioManager;

	public WeaponType currentWeapon;

	void Start () 
	{
		currentWeapon = WeaponType.PISTOL;

		weaponBase = this.transform;
		sprtRenderer = this.GetComponent<SpriteRenderer>();
	
		weapons.Add(WeaponType.PISTOL, weaponAssigning[0]);
		weapons.Add(WeaponType.UZI, weaponAssigning[1]);
		weapons.Add(WeaponType.SHOTGUN, weaponAssigning[2]);

		for (int i = 0; i < weapons.Count; i++)
		{
			weaponAssigning[i].baseWeapon = weaponBase;
		}

		SwitchSprite();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			currentWeapon = WeaponType.PISTOL;
			SwitchSprite();
		}else if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			currentWeapon = WeaponType.SHOTGUN;
			SwitchSprite();
		}else if(Input.GetKeyDown(KeyCode.Alpha3))
		{
			currentWeapon = WeaponType.UZI;
			SwitchSprite();
		}
		Debug.Log(currentWeapon);

		weapons[currentWeapon].Update();
	}

	void SwitchSprite()
	{
		switch (currentWeapon) 
		{
		case WeaponType.PISTOL:
			currentSprite = weaponAssigning[0].look;
			break;
		case WeaponType.SHOTGUN:
			currentSprite = weaponAssigning[1].look;
			break;
		case WeaponType.UZI:
			currentSprite = weaponAssigning[2].look;
			break;
		}
		sprtRenderer.sprite = currentSprite;

	}
}

public enum WeaponType
{
	PISTOL,
	UZI,
	SHOTGUN
}