
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor.Audio;
using UnityEditor;
#endif

public class TimeToggle : MonoBehaviour {


	private GameObject[] pastObjects;
	private GameObject[] presentObjects;
    private GameObject[] fadeObjects;
    private bool isPast;
    private bool isFade;
    public AudioSource sound;
    public bool isDead;

    // Use this for initialization
    void Start () {
		pastObjects = GameObject.FindGameObjectsWithTag ("Past");
		presentObjects = GameObject.FindGameObjectsWithTag ("Present");
        fadeObjects = GameObject.FindGameObjectsWithTag("Fade");
        isPast = false;
        isFade = false;
        sound.volume = .3f;
	}


	
	// Update is called once per frame
	void Update () {
        isDead = GetComponent<CharMover>().dead;
        if (Input.GetKeyDown(KeyCode.RightShift) && !isDead){
            isFade = true;
        }
		if (Input.GetKeyUp (KeyCode.RightShift) && !isDead) {
            sound.Play();
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
