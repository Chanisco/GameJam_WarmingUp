using UnityEngine;
using System.Collections;

public class ZombieWave : MonoBehaviour {
	// Update is called once per frame

	Animator animator;
	public float whenISpawn;

	void Start(){
		animator = GetComponentInChildren<Animator>();
	}
	void Update () {
		if(ArrowSpawn.i > whenISpawn){
			if(transform.position.x < 0.1f){
				transform.Translate(1 * Time.deltaTime,0,0);
			}
		}
		if(ArrowSpawn.i > 10){
			animator.speed = 5;
		}
	}
}
