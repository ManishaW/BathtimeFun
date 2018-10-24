using UnityEngine;
using System.Collections;

public class DragObject : MonoBehaviour {
	Vector3 dist;
	float posX;
	float posY;
	float clickX;

	void Update(){
		//store the x-coordinate of the mouse position
		clickX = Input.mousePosition.x;
	}

	void OnMouseDown(){
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;

		GetComponent<AudioSource>().Play ();
	}

	void OnMouseDrag(){
		Vector3 curPos = 
			new Vector3(Input.mousePosition.x - posX, 
				Input.mousePosition.y - posY, dist.z);  

		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		transform.position = worldPos;

		Vector3 v = Input.mousePosition;// subtract startvec from current finger position

		if (v.x > clickX) {
			Debug.Log ("right");
			transform.GetComponent<SpriteRenderer> ().flipX = true;
		}
		if (v.x < clickX) {
			Debug.Log ("left");
			transform.GetComponent<SpriteRenderer> ().flipX = false;
		}
		

	}
}