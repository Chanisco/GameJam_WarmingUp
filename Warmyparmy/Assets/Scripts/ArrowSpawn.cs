using UnityEngine;
using System.Collections;

public class ArrowSpawn : MonoBehaviour {
	public Rigidbody arrow1;
	public Rigidbody arrow2;
	public Rigidbody arrow3;
	public Rigidbody arrow4;

	public float bpm;
	float originalBeat;

	Vector3 spawnerPos;

	void Awake(){
		spawnerPos = new Vector3(transform.position.x,transform.position.y,0);
		bpm /= 60;
		originalBeat = bpm;
	}

	void Update (){
		if(Time.time > bpm){
			ChooseArrow(Random.Range(1,4));
			bpm += originalBeat;
		}
	}

	void ChooseArrow(float Chosen){
		if (Chosen == 1) {
			Instantiate(arrow1,spawnerPos,Quaternion.identity);
		}
		
		if (Chosen == 2) {
			Instantiate(arrow2,spawnerPos,Quaternion.identity);
		}
		
		if (Chosen == 3) {
			Instantiate(arrow3,spawnerPos,Quaternion.identity);
		}
		
		if (Chosen == 4) {
			Instantiate(arrow4,spawnerPos,Quaternion.identity);
		}
	}
	
}
