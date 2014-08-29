using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	Animator animator;
	public static float FallCount = 0;
	public static bool Fall = false;

	public  float Lives = 6;

	void Start(){
		animator = GetComponent<Animator>();

	}
	// Update is called once per frame
	void Update () {

		if(Fall){
			PositionMaker(Lives);
		}


		if(FallCount > 0){
			FallCount -= 1;
		}
		animator.SetFloat("Failing",FallCount);
		if(ArrowSpawn.i > 40){
			animator.SetBool("Solo",true);
		}

	}

	void PositionMaker(float Number){
		if(transform.position.x > Number){
			transform.Translate(new Vector3(-0.1f,0,0));
		}else{
			Lives -= 1;
			Fall = false;
		}

	}

	void OnTriggerEnter(Collider other){
		if(other.tag == Tags.Enemy){
			Destroy(gameObject);
		}

	}
}
