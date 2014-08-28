using UnityEngine;
using System.Collections;

public class ArrowDetector : MonoBehaviour {
	bool boolLeft	= false;
	bool boolRight 	= false;
	bool boolDown	= false;
	bool boolUp		= false;

	bool clear 		= true;
	

	int successiveHits = 0;

	void Update(){
		ButtonCheck();
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == Tags.arrowLeft){
			clear = false;
			boolLeft = true;
		}
		
		if(other.tag == Tags.arrowRight){
			clear = false;
			boolRight = true;
		}
		
		if(other.tag == Tags.arrowUp){
			clear = false;
			boolUp = true;
		}
		
		if(other.tag == Tags.arrowDown){
			clear = false;
			boolDown = true;
		}

	}

	void OnTriggerStay(Collider other){
		if(clear && other.gameObject != null){
			Destroy(other.gameObject);
		}

	}

	void OnTriggerExit(Collider other){
		bool Failure = false;

		if(other.tag == Tags.arrowLeft){
			boolLeft = false;
			Failure = true;
		}
		
		if(other.tag == Tags.arrowRight){
			boolRight = false;
			Failure = true;
		}
		
		if(other.tag == Tags.arrowUp){
			boolUp = false;
			Failure = true;
		}
		
		if(other.tag == Tags.arrowDown){
			boolDown = false;
			Failure = true;
		}

		if (Failure) 
		{
			Score.multiplier =1;
			Score.addScore(-1);
			successiveHits =0;
		}
		
		Destroy(other.gameObject, 0.7f);
	}

	void ButtonCheck(){
		bool Winning = false;

		if(Input.GetKeyDown(KeyCode.UpArrow) 	&& boolUp){
			boolUp = false;
			Winning = true;
		}
		if(Input.GetKeyDown(KeyCode.DownArrow) 	&& boolDown){
			boolDown = false;
			Winning = true;
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow) 	&& boolLeft){
			boolLeft = false;
			Winning = true;
		}
		if(Input.GetKeyDown(KeyCode.RightArrow) && boolRight){
			boolRight = false;
			Winning = true;
		}

		if (Winning) 
		{
			clear = true;
			Score.addScore(1);
			successiveHits ++;
			if (successiveHits % 2 == 0)
			{
				Score.multiplier*=2;
				print(Score.multiplier);
			}
		}

	}
	
}
