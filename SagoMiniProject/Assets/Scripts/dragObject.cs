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
		//when clicked on object get the coordinates
		dist = Camera.main.WorldToScreenPoint(transform.position);
		posX = Input.mousePosition.x - dist.x;
		posY = Input.mousePosition.y - dist.y;

		GetComponent<AudioSource>().Play ();
	}

	//dragging
	void OnMouseDrag(){
		//drag the object
		Vector3 curPos = 
			new Vector3(Input.mousePosition.x - posX, 
				Input.mousePosition.y - posY, dist.z);  

		Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
		transform.position = worldPos;

		//current position
		Vector3 v = Input.mousePosition;

		//flip the object in the direction it is going
		if (v.x > clickX) {
			transform.GetComponent<SpriteRenderer> ().flipX = true;
		}
		if (v.x < clickX) {
			transform.GetComponent<SpriteRenderer> ().flipX = false;
		}
		

	}
}