using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**
* ...
* @author Niek Schoone
**/

public class EnemySpawner : MonoBehaviour 
{
	public List<GameObject> enemies = new List<GameObject>();
	private int nextWaveTime;
	private int enemyAmount;
	private int waveCount;

	void Start()
	{
		nextWaveTime = 30;
		enemyAmount = 1;
		waveCount = 0;

		StartCoroutine(initWave());
	}

	IEnumerator initWave()
	{
		yield return new WaitForSeconds(nextWaveTime);
		Wave();
	}

	IEnumerator initEnemy(int seconds)
	{
		yield return new WaitForSeconds(seconds);
		Instantiate(enemies[0], this.transform.position, this.transform.rotation);
	}

	void Wave()
	{
		for (int i = 0; i < enemyAmount; i++) 
		{
			StartCoroutine(initEnemy(1 * i));
		}

		enemyAmount = enemyAmount + 1;
		waveCount = waveCount + 1;
		StartCoroutine(initWave());
	}
}
