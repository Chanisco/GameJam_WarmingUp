using UnityEngine;
using System.Collections;

public class LayerParticle : MonoBehaviour {

	public string Place;
	// Use this for initialization
	void Start () {
		particleSystem.renderer.sortingLayerName = Place;
	}

}
