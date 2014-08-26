using UnityEngine;
using System.Collections;

public class ArrowSpawn : MonoBehaviour {


	public Rigidbody arrowholder;

	
	
	void Update ()
	{



		if(Input.GetKeyDown(KeyCode.Space))
		{

			Instantiate(arrowholder);
			Debug.Log("it works");

		}
	}
}
