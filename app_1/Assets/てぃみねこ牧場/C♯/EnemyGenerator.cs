using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

	public GameObject EnemyPrefab;

	void Start () {
		InvokeRepeating ("GenEnemy", 0, 10);
	}

	void GenEnemy () {
		Instantiate (EnemyPrefab, new Vector3 (-2.5f + 5 * Random.value, -2.5f + 5 * Random.value, 0), Quaternion.identity);
	}
}
