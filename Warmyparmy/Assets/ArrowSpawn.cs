using UnityEngine;
using System.Collections;

public class ArrowSpawn : MonoBehaviour {


	public Rigidbody arrowone;
	public Rigidbody arrowtwo;
	public Rigidbody arrowthree;
	public Rigidbody arrowfour;



	
	
	void Update ()
	{
		if (Random.Range (0, 4) == 1) 
		{
			Instantiate(arrowthree);
		}



		if(Input.GetKeyDown(KeyCode.Space))
		{

			Instantiate(arrowone);
			Debug.Log("it works");

		}
	}
}
