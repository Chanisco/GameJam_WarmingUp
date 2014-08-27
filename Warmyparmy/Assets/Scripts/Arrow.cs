using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		transform.Translate(1 * Time.deltaTime,0,0);

		if (transform.position.x > 3.5f){
			Destroy (gameObject);

		}
	}

}
