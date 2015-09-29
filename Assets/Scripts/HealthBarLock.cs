using UnityEngine;
using System.Collections;

public class HealthBarLock : MonoBehaviour 
{
	private Quaternion rotation;
	public Transform target;

	void Awake () 
	{
		rotation = transform.rotation;
		target = target.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.rotation = rotation;
		transform.position = new Vector3(target.transform.position.x, target.transform.position.y + 1.2f, target.transform.position.z);
	}
}
