/*Developed by Chanisco Tromp*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class Beats{
	

	//The Times for all the beats//
	static public List<Note> Ritme = new List<Note>{ 
		new Note(0,0.3f,1),
		new Note(0,0.8f,1),
		new Note(0,1.2f,2),
		new Note(0,1.6f,3),
 		new Note(0,1.9f,1),
        new Note(0,2.25f,1),//Beat 1 Difference = 2.6f

        new Note(0,4.9f,1),
		new Note(0,5.4f,1),
		new Note(0,5.8f,2),
		new Note(0,6.2f,3),
		new Note(0,6.5f,1),
		new Note(0,6.85f,1),//Beat 2

		new Note(0,9.4f,1),
		new Note(0,9.9f,1),
		new Note(0,10.3f,2),
		new Note(0,10.7f,3),
		new Note(0,11.0f,1),
		new Note(0,11.35f,1),//Beat 3

		new Note(0,13.9f,1),
		new Note(0,14.4f,1),
		new Note(0,14.8f,1),
		new Note(0,15.2f,1),
		new Note(0,15.5f,1),
		new Note(0,15.85f,1),//Beat 4

		/*18.3f,
		18.5f,
		18.7f,
		18.9f,
		19.2f,
		20.25f,//Beat 5*/

		new Note(0,23.3f,4),
		new Note(0,23.5f,3),
		new Note(0,23.7f,2),
		new Note(0,24.2f,1),
		new Note(0,24.5f,1),
		//24.8f, 3.5f

		new Note(0,28.0f,4),
		new Note(0,28.2f,3),
		new Note(0,28.4f,2),
		new Note(0,28.9f,1),
		new Note(0,29.2f,1),

		new Note(0,32.7f,4),
		new Note(0,32.9f,3),
		new Note(0,33.2f,2),
		new Note(0,33.7f,1),
        new Note(0,33.9f,1),

		//37.4f,

		//38.0f,
		new Note(0,39.45f,2),
		new Note(0,39.5f,3),
		new Note(0,40.3f,3),
		new Note(0,40.4f,3),
		new Note(0,40.7f,3),
		new Note(0,42.3f,3),




	};


	public class Note{
		private int id;
		private float hit;
		private int arrow;

		public Note(int Id,float Hit,int Arrow){
			id = Id;
			hit = Hit;
			arrow = Arrow;

		}

		public float Hit{
			get
			{
				return hit;
			}
		}
		public int Arrow{
			get
			{
				return arrow;
			}
		}
	}

}
