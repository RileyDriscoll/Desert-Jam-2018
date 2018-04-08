
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Audio;
#endif

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
