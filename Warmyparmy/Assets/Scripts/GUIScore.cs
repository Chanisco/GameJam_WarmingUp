using UnityEngine;
using System.Collections;

public class GUIScore : MonoBehaviour {
	
	public GUIText ScoreIndicator;
	private float lastScore;

	void Update () 
	{
		if (ScoreIndicator != null)
		{
			float newScore = Score.MainScore;
			if (newScore != lastScore)
			{
				ScoreIndicator.text = "score: " + newScore;
				lastScore = newScore;
			}

		}

	}
}
