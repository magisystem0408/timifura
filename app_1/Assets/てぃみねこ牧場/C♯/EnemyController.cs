using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	float xSpeed;
	float ySpeed;
	int k;

	void Start () {
		InvokeRepeating ("GenMove", 0, 2);
	}

	void GenMove(){
		this.k=(int)Random.Range(0.0f,2.0f);
		this.xSpeed = 0.025f * Random.Range(-1.0f,1.0f);
		this.ySpeed = 0.025f * Random.Range(-1.0f,1.0f);
	}

	void Update () {
		if (k==0){
			transform.Translate( xSpeed, ySpeed, 0, Space.World);
		}
	}
}
