using UnityEngine;
using System.Collections;

public class ZombieAnimator : MonoBehaviour {

	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(ArrowSpawn.i > 40){
			animator.SetBool("Solo",true);
			animator.speed = 2;
		}
	}
}
