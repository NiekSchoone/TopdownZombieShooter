using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{
	private float maxHealth;
	private float currentHealth;

	public GameObject healthBar;

	void Start () 
	{
		maxHealth = 100;
		currentHealth = maxHealth;
	}

	public void HeatlthDecrease(int damage)
	{
		currentHealth -= damage;
		float calcHealth = currentHealth / maxHealth;
		SetHealthBar(calcHealth);
		Death();
	}

	public void Death()
	{
		if(currentHealth <= 0)
		{
			Destroy(this.gameObject);
			if(this.gameObject.tag == "Player")
			{

			}
		}
	}

	public void SetHealthBar(float myHealth)
	{
		healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
}
