using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ouch")
            GetComponent<CharMover>().dead = true;

    }
    // Update is called once per frame
    void Update () {
		
	}
}
