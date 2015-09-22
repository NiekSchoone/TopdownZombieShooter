using UnityEngine;
using System.Collections;

/**
* ...
* @author Niek Schoone
**/

public class SmoothCamera2D : MonoBehaviour 
{
	public float dampTime;
	private Vector3 velocity;
	public Transform target;

	private Camera usingCamera;

	private float rLimit;
	private float lLimit;
	private float tLimit;
	private float bLimit;

	void Start()
	{
		usingCamera = this.GetComponent<Camera>();

		dampTime = 0.15f;

		velocity = Vector3.zero;

		usingCamera = GetComponent<Camera>();

		rLimit = 2f;
		lLimit = -2f;
		tLimit = 1.2f;
		bLimit = -4.2f;
	}
	
	void Update () 
	{
		if (target)
		{
			Vector3 point = usingCamera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - usingCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
			transform.position = new Vector3(Mathf.Clamp(transform.position.x, lLimit, rLimit), Mathf.Clamp(transform.position.y, bLimit, tLimit), transform.position.z);
		}
		
	}
}
