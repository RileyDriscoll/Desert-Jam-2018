using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToggle : MonoBehaviour {


	private GameObject[] pastObjects;
	private GameObject[] presentObjects;
	private bool isPast;

	// Use this for initialization
	void Start () {
		pastObjects = GameObject.FindGameObjectsWithTag ("Past");
		presentObjects = GameObject.FindGameObjectsWithTag ("Present");
		isPast = false;
	}


	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightShift)) {
			isPast = !isPast;
		}
		foreach (GameObject obj in pastObjects) {
			obj.SetActive (isPast);
		}
		
		foreach (GameObject obj in presentObjects) {
			obj.SetActive (!isPast);
		}
	}
}
