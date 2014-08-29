/*
 * 29 / 09 / 14  
 * Swan Chase
 * FDH
*/

using UnityEngine;
using System.Collections;

public class Scorebar : MonoBehaviour 
{
	public Texture2D backTexture;
	public Texture2D BarTexture;
	public Texture2D frontTexture;

	public Vector2 Position = new Vector2(20,20);
	public Vector2 Size = new Vector2(150,30);

	private int Max ;

	void Start ()
	{
		Max = Beats.Ritme.Count;
	}

	void OnGUI()
	{
		if (backTexture != null)
		{
			GUI.DrawTexture(new Rect(Position.x,Position.y,Size.x,Size.y),backTexture);
		}
		if (BarTexture != null)
		{
			int current = ArrowDetector.totalSuccessiveHits;
			float percentage = (float)current / (float)Max;
			GUI.DrawTexture(new Rect(Position.x,Position.y,Size.x * percentage,Size.y),BarTexture);
		}
		if (frontTexture != null)
		{
			GUI.DrawTexture(new Rect(Position.x,Position.y,Size.x,Size.y),frontTexture);
		}
	}
}
