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
	float waveCounter;
	float waveNumber;
	float waveAdder;

	public bool musicStart = false;
	public AudioClip Song;
	public static int i = 0;

	void Awake(){
		spawnerPos = new Vector3(transform.position.x,transform.position.y,0);
		bpm = 60 / bpm;
		originalBeat = bpm;
		waveAdder = originalBeat * 5;
	}

	void Update (){
		if(!musicStart){
			AudioSource.PlayClipAtPoint(Song,new Vector3(0,0,0));
			musicStart = true;
		}
		if(i != Beats.Ritme.Count - 1){
			if(Time.time > /*bpm*/ Beats.Ritme[i]){
				ChooseArrow(Random.Range(1,4));
				bpm += originalBeat;
				waveCounter += 1;
				i++;
			}
		}

		if(waveCounter > 5){
			bpm += waveAdder;
			waveNumber += 1;
			waveCounter = 0;
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
