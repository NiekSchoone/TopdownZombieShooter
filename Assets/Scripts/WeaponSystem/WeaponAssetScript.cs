using UnityEngine;
using System.Collections;
using System.IO;
using System;
using UnityEditor;

public class WeaponAssetScript : Editor 
{

	void Start()
	{
		Debug.Log ("I am working");
	}

	[MenuItem("Tools/Regenerate Weapon Scripts")]
	static void RegenerateWeaponAsset()
	{
		string path = Application.dataPath + "/Scripts/WeaponSystem/Weapons/";
		
		string[] weaponsFull = Directory.GetFiles(path);
		
		
		int x = 0;
		foreach( string str in weaponsFull)
		{
			string filename = str.Substring(str.LastIndexOf("/") +1);
			
			if(filename.EndsWith(".cs"))
			{
				string getName = filename.Remove(filename.Length -3);
				
				var weaponType = getName;
				var weapon = ScriptableObject.CreateInstance(weaponType);
				AssetDatabase.CreateAsset(weapon,"Assets/Weapon/" + weaponType + ".asset");
				AssetDatabase.SaveAssets();
				
				Debug.Log(getName);
				x++;
			}
		}
	}
}
