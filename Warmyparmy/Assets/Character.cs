using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	Animator animator;
	float FallCount = 0;

	void Start(){
		animator = GetComponent<Animator>();

	}
	// Update is called once per frame
	void Update () {
		if(FallCount > 0){
			FallCount -= 1;
		}

		if(ArrowSpawn.i > 20){
			animator.SetBool("Solo",true);
		}




	}
}
