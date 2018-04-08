
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor.Audio;
using UnityEditor;
#endif

public class TitleCam : MonoBehaviour {

    public bool enterPressed;
    private float offset;
    public AudioSource stingSource;
    public AudioSource source2;
    // Use this for initialization
    void Start () {
        enterPressed = false;
        GetComponent<CammeraFollow>().enabled = false;
        stingSource.loop = true;
        source2.loop = true;
        stingSource.Play();
        stingSource.volume = 1.0f;
        source2.Play();
        source2.volume = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return)) {
            enterPressed = true;
        }

        if (enterPressed && (transform.position.y > -1.5)) {
            transform.position = new Vector3(0, transform.position.y +   ( -1.5f-transform.position.y) * Time.deltaTime, -10 );
            stingSource.volume = stingSource.volume - .05f;
            source2.volume = source2.volume + .05f;
        }

        if (transform.position.y <= -1) {
            GetComponent<CammeraFollow>().enabled = true;
            GetComponent<TitleCam>().enabled = false;
        }

        if (!enterPressed){
            transform.position = new Vector3(0, 50, -10);
        }
	}
}
