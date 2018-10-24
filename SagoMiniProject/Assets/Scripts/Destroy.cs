using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnBecameInvisible() {
		//destroy the object if it goes outside the camera view
		Destroy(this.gameObject);
		Debug.Log (this.gameObject.name);
	}
}
