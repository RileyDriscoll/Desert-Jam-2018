using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToggle : MonoBehaviour {


	private GameObject[] pastObjects;
	private GameObject[] presentObjects;
    private GameObject[] fadeObjects;
    private bool isPast;
    private bool isFade;

	// Use this for initialization
	void Start () {
		pastObjects = GameObject.FindGameObjectsWithTag ("Past");
		presentObjects = GameObject.FindGameObjectsWithTag ("Present");
        fadeObjects = GameObject.FindGameObjectsWithTag("Fade");
        isPast = false;
        isFade = false;
	}


	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.RightShift)){
            isFade = true;
        }
		if (Input.GetKeyUp (KeyCode.RightShift)) {
			isPast = !isPast;
            isFade = false;
		}
		foreach (GameObject obj in pastObjects) {
			obj.SetActive (isPast);
		}
		
		foreach (GameObject obj in presentObjects) {
			obj.SetActive (!isPast);
		}

        foreach (GameObject obj in fadeObjects)
        {
            obj.SetActive(isFade);
        }
    }
}
