//
// 29 / 09 / 14 
// Swan Chase
// FDH
//

using UnityEngine;
using System.Collections;

public class startMenuGUI : MonoBehaviour
{
	// Textures
	public Texture2D background;
	public Texture2D instructionBackground;
	public Texture2D credzBackground;
	public Texture2D startButtonTexture;
	public Texture2D instructionButtonTexture;
	public Texture2D creditsButtonTexture;
	public Texture2D quitButtonTexture;
	public Texture2D backButtonTexture;

	private int buttSizeX = 224;
	private int buttSizeY = 32;
	private int buttPosX, buttPosY;
	private int buttSpacing = 10;

	private int currentMenu = 0;

	void Start()
	{
		buttPosX = (Screen.width - buttSizeX) / 2;
		buttPosY = 270; 
	}
	void OnGUI()
	{
		if (currentMenu == 0) 
		{
			mainMenu ();
		}
		else if (currentMenu == 1)
		{
			instructMenu();
		}
		else if (currentMenu == 2)
		{
			credzMenu();
		}
	}

	void mainMenu()
	{
		if (background != null) 
		{
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),background);
		}
		if (startButtonTexture != null) 
		{
			if (GUI.Button (new Rect(buttPosX,buttPosY + (buttSizeY + buttSpacing)*0,buttSizeX,buttSizeY), startButtonTexture, GUIStyle.none))
			{ // start
				Application.LoadLevel(0);
			}
		}
		if (instructionButtonTexture != null) 
		{
			if (GUI.Button (new Rect(buttPosX,buttPosY + (buttSizeY + buttSpacing)*1,buttSizeX,buttSizeY), instructionButtonTexture, GUIStyle.none))
			{// instructions
				currentMenu =1;
			}
		}
		if (creditsButtonTexture != null) 
		{
			if (GUI.Button (new Rect(buttPosX,buttPosY + (buttSizeY + buttSpacing)*2,buttSizeX,buttSizeY), creditsButtonTexture, GUIStyle.none))
			{ // credz
				currentMenu =2;
			}
		}
		if (quitButtonTexture != null) 
		{
			if (GUI.Button (new Rect(buttPosX,buttPosY + (buttSizeY + buttSpacing)*3,buttSizeX,buttSizeY), quitButtonTexture, GUIStyle.none))
			{// quit
				Application.Quit();
			}
		}
	}
	void instructMenu()
	{
		if (instructionBackground !=null)
		{
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),instructionBackground);
		}
		if (backButtonTexture != null)
		{
			if (GUI.Button (new Rect(Screen.width - buttSizeX,Screen.height - buttSizeY,buttSizeX,buttSizeY), backButtonTexture, GUIStyle.none))
			{//back
				currentMenu =0;
			}
		}
	}
	void credzMenu()
	{
		if (credzBackground !=null)
		{
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),credzBackground);
		}
		if (backButtonTexture != null)
		{
			if (GUI.Button (new Rect(Screen.width - buttSizeX,Screen.height - buttSizeY,buttSizeX,buttSizeY), backButtonTexture, GUIStyle.none))
			{//back
				currentMenu =0;
			}
		}
	}
}
