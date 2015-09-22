using UnityEngine;
using System.Collections;

public class EnemyChase : MonoBehaviour 
{

	public Transform target;

	private float step;

	void Start () 
	{
		target = GameObject.Find ("Player").GetComponent<Transform>();
	}
	
	void Update () 
	{
		step = 3 * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}
