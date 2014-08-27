using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		transform.Translate(2 * Time.deltaTime,0,0);

		if (transform.position.x > 10){
			Destroy (gameObject);

		}
	}

}
