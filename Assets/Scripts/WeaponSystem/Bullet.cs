using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
	private Rigidbody2D rb2D;

	private float maxSpeed;
	
	void Start()
	{
		rb2D = this.GetComponent<Rigidbody2D>();

		maxSpeed = 10f;
	}

	void FixedUpdate() 
	{
		rb2D.AddForce(transform.up * 200);
		rb2D.velocity = Vector2.ClampMagnitude(rb2D.velocity, maxSpeed);

		if(transform.position.x <= -10 || transform.position.x >= 10 || transform.position.y <= -8 || transform.position.y >= 10)
		{
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Enemy")
		{

		}
		Destroy(this.gameObject);
	}
}
