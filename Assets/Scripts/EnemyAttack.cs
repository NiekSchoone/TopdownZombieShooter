using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour 
{
	private float attackCooldown;
	private int myDamage;

	void Start()
	{
		myDamage = 5;
		attackCooldown = 0;
	}

	void Update()
	{
		if(attackCooldown >= 0)
		{
			attackCooldown -= Time.deltaTime;
		}
	}

	void OnCollisionStay2D(Collision2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			if (attackCooldown <= 0) 
			{
				col.gameObject.GetComponent<Health>().HeatlthDecrease(myDamage);
				attackCooldown = 2;
			}
		}
	}
}
