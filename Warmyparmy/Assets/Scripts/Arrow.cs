using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {
	// Update is called once per frame
	float speed;
	void Update () {
		speed = 5 * Time.deltaTime;
		transform.Translate(speed,0,0);
	}

}
