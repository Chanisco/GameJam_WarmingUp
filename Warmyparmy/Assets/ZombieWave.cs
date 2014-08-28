using UnityEngine;
using System.Collections;

public class ZombieWave : MonoBehaviour {
	// Update is called once per frame

	public float whenISpawn;
	void Update () {
		if(ArrowSpawn.i > whenISpawn){
			if(transform.position.x < 0.1f){
				transform.Translate(1 * Time.deltaTime,0,0);
			}
		}
	}
}
