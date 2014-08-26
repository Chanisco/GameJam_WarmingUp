using UnityEngine;
using System.Collections;

public class ArrowDetector : MonoBehaviour {
	bool boolLinks	= false;
	bool boolRechts = false;
	bool boolOmhoog	= false;
	bool boolOmlaag	= false;
	void Update(){

	}

	void OnTriggerEnter(Collider other){
		if(other.tag == Tags.PijltjeLinks){
			boolLinks = true;
		}
		
		if(other.tag == Tags.PijltjeRechts){
			boolRechts = true;
		}
		
		if(other.tag == Tags.PijltjeOmhoog){
			boolOmhoog = true;
		}
		
		if(other.tag == Tags.PijltjeLinks){
			boolLinks = true;
		}

	}
}
