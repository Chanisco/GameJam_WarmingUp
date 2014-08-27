using UnityEngine;
using System.Collections;

public class ScreenBtns : MonoBehaviour {
		
	public Texture2D background, LOGO, startBtn, howtoBtn, statBtn, controllsBtn;
	public Texture2D optionBtn, creditBtn, quitbtn, volumeBox, brightBox, backBtn;
	public Texture2D controlBtn,tutBtn;

	public GUISkin guiSkin;
	public string LvlName = "" , TutName = "";
	public string[] AboutTextLines = new string[0];
	
	
	private string clicked = "", MessageDisplayOnAbout = "This game is made by Team Oink \n ";
	private Rect WindowRect = new Rect(Screen.width / 2, Screen.height / 10, Screen.width / 4, Screen.height);
	private Rect HugeRect = new Rect(0, 0, Screen.width, Screen.height);
	private float volume = 1.0f;
	
	private void Start()
	{
		Screen.orientation = ScreenOrientation.Portrait;
		//---------------------de credits worden hierin gestopt zodat het al klaar staat---------------------//
		for (int x = 0; x < AboutTextLines.Length;x++ ){
			MessageDisplayOnAbout += AboutTextLines[x] + " \n ";

		}
		MessageDisplayOnAbout += "Use two fingers to return to main";
	}

	//---------------------de function om bij een click een andere te kiezen------------------------------------------//
	private void OnGUI()
	{
		/*if(Screen.orientation == ScreenOrientation.LandscapeLeft){
			Rect HugeRect = new Rect(0, 0, Screen.height, Screen.width);
		}else{
			Rect HugeRect = new Rect(0, 0, Screen.width, Screen.height);
		}*/
		if (background != null)
			GUI.DrawTexture(new Rect(0,0,Screen.width , Screen.height),background);
		if (LOGO != null && clicked != "credits")
			GUI.DrawTexture(WindowRect, LOGO);
		
		GUI.skin = guiSkin;
		if (clicked == ""){
			WindowRect = GUI.Window(0, HugeRect, menuFunc, "Main Menu" ,GUIStyle.none);

		}
		/*else if(clicked == "howToPlay"){
			WindowRect = GUI.Window(1, HugeRect, HowToFunc, "howToPlay" ,GUIStyle.none);

		}*/
		/*else if(clicked == "stat"){
			WindowRect = GUI.Window(2, HugeRect, StatFunc, "Your Stats" ,GUIStyle.none);

		}*/
		else if (clicked == "options"){
			WindowRect = GUI.Window(3, HugeRect, optionsFunc, "Options" ,GUIStyle.none);

		}
		else if (clicked == "credits"){
			GUI.Box(new Rect (0,0,Screen.width,Screen.height), MessageDisplayOnAbout);

		}
	}


	//-----------------------De option field----------------------//
	private void optionsFunc(int id)
	{
		GUILayout.Box(volumeBox,GUIStyle.none);
		volume = GUILayout.HorizontalSlider(volume ,0.0f,1.0f);
		AudioListener.volume = volume;

		if (GUILayout.Button(brightBox,GUIStyle.none)){
			Debug.Log("Brightness");
			
		}

		if (GUILayout.Button(controlBtn,GUIStyle.none)){
			Debug.Log("Controlls");
				
		}


		if (GUILayout.Button(backBtn,GUIStyle.none)){
			clicked = "";

		}
	}

	//------------------------------------------------How to play Scherm----------------------------//
	private void HowToFunc(int id){
		GUILayout.Box(startBtn);

		if(GUILayout.Button(tutBtn,GUIStyle.none)){
			Application.LoadLevel(TutName);
		}
		if (GUILayout.Button(backBtn,GUIStyle.none)){
			clicked = "";

		}
	}

	//-------------------------------------------------Stat Scherm--------//
	/*private void StatFunc(int id){
	/*	string killPoints 		= GlobalValues.KillCount.ToString();
		string expPoints 		= GlobalValues.ExpCount.ToString();
		string goldPoints 		= GlobalValues.ExpCount.ToString();
		string widthPoints 		= Screen.width.ToString();
		string heightPoints 	= Screen.height.ToString();
		GUI.skin.box.fontSize = 20;
		GUILayout.Box("KillCount = " 	+ killPoints);
		GUILayout.Box("Exp earned = " 	+ expPoints);
		GUILayout.Box("Gold earned = " 	+ goldPoints);
		GUILayout.Box("Screenwidth = " 	+ widthPoints);
		GUILayout.Box("screenheight = " + heightPoints);

		if (GUILayout.Button(backBtn,GUIStyle.none)){
			clicked = "";

		}
	}*/

	//------------------------------------------------Main Menu Scherm----------------------------//
	private void menuFunc(int id)
	{
		if (GUILayout.Button(startBtn,GUIStyle.none)){
//			GlobalValues.screenStance = true;
			Application.LoadLevel(LvlName);

		}
		/*if (GUILayout.Button(howtoBtn,GUIStyle.none)){
			clicked = "howToPlay";
			
		}*/
		if (GUILayout.Button(statBtn,GUIStyle.none)){
			clicked = "stat";

		}

		/*if (GUILayout.Button(optionBtn,GUIStyle.none)){
			clicked = "options";

		}*/
		if (GUILayout.Button(creditBtn,GUIStyle.none)){
			clicked = "credits";

		}
		if (GUILayout.Button(quitbtn,GUIStyle.none)){
			Application.Quit();

		}
	}
	//----------------------------------------overige functies die buiten de menu gebeuren-----------------------//
	private void Update()
	{
		if (clicked == "credits" && Input.touchCount == 2)
			clicked = "";
	}
}
