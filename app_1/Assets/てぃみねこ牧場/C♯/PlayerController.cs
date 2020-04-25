using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	int n;
	float xv;
	float yv;
	int bCount=0;
	public TapController tapController;

	void Start(){
		InvokeRepeating ("GenMove", 0, 2);
	}

	void GenMove(){
		this.n=(int)Random.Range(0.0f,2.0f);
		this.xv = 0.025f * Random.Range(-1.0f,1.0f);
		this.yv = 0.025f * Random.Range(-1.0f,1.0f);
	}

	void Update () {
		bCount = tapController.a;
    Debug.Log(bCount);
		if (n==0){
			transform.Translate( xv, yv, 0, Space.World);
		}
		if(bCount==1){
			Debug.Log("kidou");
			transform.position = tapController.touchWorldPosition;
		}
	}
}
