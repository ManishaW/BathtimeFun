﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faucet_controller : MonoBehaviour {
	public Transform prefab;
	private IEnumerator coroutine;
	// Use this for initialization
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
						Instantiate (prefab, new Vector3 (15f, 12f, 0), Quaternion.identity);


					}

				}
			}
		} else {
			Debug.Log ("not held down");
		}
	}

}
