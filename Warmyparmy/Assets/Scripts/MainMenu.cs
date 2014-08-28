using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;

	void onGUI()
	{
		//display background texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width,Screen.height), backgroundTexture);

		//display buttons

		if(GUI.Button(new Rect(Screen.width * .5f, Screen.height * .5f, Screen.width * .5f, Screen.height * .1f), "Play Game")){

		}

	}


}
