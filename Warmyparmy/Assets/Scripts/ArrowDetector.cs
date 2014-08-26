﻿using UnityEngine;
using System.Collections;

public class ArrowDetector : MonoBehaviour {
	bool boolLeft	= false;
	bool boolRight 	= false;
	bool boolDown	= false;
	bool boolUp		= false;

	bool clear 		= true;

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

		if(clear && other.gameObject.transform != null){
			Destroy(other.gameObject);
		}
		Debug.Log(other.gameObject.name);

	}

	void OnTriggerExit(Collider other){
		if(other.tag == Tags.arrowLeft){
			boolLeft = false;
		}
		
		if(other.tag == Tags.arrowRight){
			boolRight = false;
		}
		
		if(other.tag == Tags.arrowUp){
			boolUp = false;
		}
		
		if(other.tag == Tags.arrowDown){
			boolDown = false;
		}
		
		if(clear && other.gameObject.transform != null){
			Destroy(other.gameObject);
		}
	}

	void ButtonCheck(){
		if(Input.GetKeyDown(KeyCode.UpArrow) 	&& boolUp){
			Debug.Log ("This is up");
			clear = true;
		}
		if(Input.GetKeyDown(KeyCode.DownArrow) 	&& boolDown){
			Debug.Log ("Ain't letting you down");
			clear = true;
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow) 	&& boolLeft){
			Debug.Log ("Left is always right");
			clear = true;
		}
		if(Input.GetKeyDown(KeyCode.RightArrow) && boolRight){
			Debug.Log ("Never knew right over wrong...");
			clear = true;
		}
	}
	
}
