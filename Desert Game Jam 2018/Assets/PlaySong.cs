using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Audio;

public class PlaySong : MonoBehaviour {

    public AudioSource source2;
    // Use this for initialization
    void Start () {
        source2.loop = true;
        source2.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
