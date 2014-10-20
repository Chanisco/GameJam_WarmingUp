//****Developed by Chanisco Tromp****//
using UnityEngine;
using System.Collections;

public class ArrowSpawn : MonoBehaviour {
	public Rigidbody arrow1;
	public Rigidbody arrow2;
	public Rigidbody arrow3;
	public Rigidbody arrow4;

	public float bpm;
	float originalBeat;
	float waveCounter;
	float waveNumber;
	float waveAdder;
	float time;

	Vector3 spawnerPos;

	private bool musicStart = false;
	public AudioClip Song;
	public static int i = 0;


	bool SceneStart = false;

	void Awake(){
		//Calculate the BPM//
		spawnerPos = new Vector3(transform.position.x,transform.position.y,0);
		bpm = 60 / bpm;
		originalBeat = bpm;
		waveAdder = originalBeat * 5;

	}

	void Start(){
		//The scene is ready and going to start//
		SceneStart = true;
	}

	void Update (){
		/*There was a bug that the music would start before the game would start
		 * This way the arrows and the music will start at the same time as the game

		 */
		time = time + Time.deltaTime;
		if(!musicStart){
			AudioSource.PlayClipAtPoint(Song,new Vector3(0,0,0));
			musicStart = true;
		}
		if(i != Beats.Ritme.Count - 1){
			if(time > /*bpm*/ Beats.Ritme[i].Hit){
				ChooseArrow(Beats.Ritme[i].Arrow);
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

	//All the Arrows have an own id and will spawn when their Id is called
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
