using UnityEngine;
using System.Collections;

public class TapController : MonoBehaviour {

	  public GameObject explosionPrefab;
		public GameObject EnemyDPrefab;
	  public int a;
	  public Vector3 touchWorldPosition;


	void OnTriggerEnter2D(Collider2D coll) {
		if(Input.GetMouseButton(0)) {
			if(coll.gameObject.tag == "Enemy"){
        GameObject effect = Instantiate (explosionPrefab, transform.position, Quaternion.identity) as GameObject;
			  Destroy (effect, 1.0f);
			  Destroy (coll.gameObject);
				Instantiate (EnemyDPrefab, transform.position, Quaternion.identity);
		    //Destroy (gameObject);
				a=1;
      }
			if(coll.gameObject.tag == "EnemyD"&&a==0){
				Destroy(coll.gameObject);
				a=1;
				GameObject.Find ("Canvas").GetComponent<UIController> ().AddScore ();
				GameObject.Find ("Canvas").GetComponent<UIController> ().AddScore ();
			}
		}
	}

	void Update () {
		if(Input.GetMouseButton(0)) {
				Vector3 touchScreenPosition = Input.mousePosition;
				touchScreenPosition.z       = 10.0f;
				Camera  gameCamera          = Camera.main;
				touchWorldPosition  = gameCamera.ScreenToWorldPoint( touchScreenPosition );
				transform.position = touchWorldPosition;
		}else{
			a=0;
		}

	}
}
