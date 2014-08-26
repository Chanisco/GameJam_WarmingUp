using UnityEngine;
using System.Collections;

public class Score2 : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {

		if (Input.anyKeyDown) {
			Score.MainScore += 1;		
		}
						
	
	}
}
