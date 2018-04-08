using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinkers : MonoBehaviour {

    public float timer;
    private bool switcher;

	// Use this for initialization
	void Start () {
        timer = 1.0f;
        switcher = true;


	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0) {
            switcher = !switcher;
            if (switcher)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -1);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 1);
            }
            timer = 1.0f;
        }

        

    }
}
