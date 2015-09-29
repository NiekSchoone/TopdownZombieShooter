using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
	private int myDamage;

	void Start()
	{
		myDamage = 20;
	}

	void FixedUpdate() 
	{
		transform.position += transform.up / 1.5f;

		if(transform.position.x <= -10 || transform.position.x >= 10 || transform.position.y <= -10 || transform.position.y >= 10)
		{
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Enemy")
		{
			col.gameObject.GetComponent<Health>().HeatlthDecrease(myDamage);
			Destroy(this.gameObject);
		}

	}
}
