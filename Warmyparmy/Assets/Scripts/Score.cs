using UnityEngine;
using System.Collections;

public static class Score {

	public static float MainScore;
	public static float multiplier = 1f;

	public static void addScore(float score)
	{
		Score.MainScore += score * Score.multiplier;
	}
}
