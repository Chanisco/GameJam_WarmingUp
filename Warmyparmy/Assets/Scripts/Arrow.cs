/****Developed by Chanisco Tromp*****/
using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {
	// Update is called once per frame
	float speed;
	void Update () {
		if(ArrowSpawn.i < 40){
			speed = 5 * Time.deltaTime;
		}else{
			speed = 7 * Time.deltaTime;
		}
		transform.Translate(speed,0,0);
	}

}
