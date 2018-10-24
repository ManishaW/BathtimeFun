using UnityEngine;
using System.Collections;

public class DragObject : MonoBehaviour {
	Vector3 dist;
	float posX;
	float posY;


	void OnMouseDown(){
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;
		Debug.Log ("clicked");
		GetComponent<AudioSource>().Play ();
	}

	void OnMouseDrag(){
		Vector3 curPos = 
			new Vector3(Input.mousePosition.x - posX, 
				Input.mousePosition.y - posY, dist.z);  

		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		transform.position = worldPos;

		Vector3 v = Input.mousePosition- dist;// subtract startvec from current finger position
		if(v.x < 0) Debug.Log("right");
		if(v.x > 0) Debug.Log("left");
	

	}
}