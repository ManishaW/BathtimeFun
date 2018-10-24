using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour {
	public Transform prefab;
	private IEnumerator coroutine;
	// Use this for initialization
	double waitTime = 0.5f;
	double charge = 0.0;
	void Start () {
		

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) {
			Debug.Log ("hold down");
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit, 100.0f)) {

				if (hit.transform != null) {
					Debug.Log (hit.transform.gameObject);

					if (hit.transform.tag == "faucet") {
						Instantiate (prefab, new Vector3 (15f, 15f, 0), Quaternion.identity);
						hit.transform.Rotate (new Vector3 (0, 0, -200) * Time.deltaTime);
						hit.transform.gameObject.GetComponents<AudioSource>()[0].Play ();
//						Debug.Log(hit.transform.gameObject.GetComponents<AudioSource>().Length);

					}
					if (hit.transform.tag == "drainer") {
						Debug.Log ("yikes");
						hit.transform.gameObject.GetComponents<AudioSource>()[0].Play ();
						hit.transform.gameObject.GetComponents<Animation> ()[0].Play();
					}
				}
			}
		} else {
			Debug.Log ("not held down");
		}
	
	}

}
