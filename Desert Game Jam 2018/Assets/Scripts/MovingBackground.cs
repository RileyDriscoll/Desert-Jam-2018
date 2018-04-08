using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour {

    public float depth;
    public GameObject mainCamera;
    private float zPos;
    private float yPos;
    private float xPos;
    public float offset;

    private SpriteRenderer sren;

	// Use this for initialization
	void Start () {
        zPos = transform.position.z;
        yPos = transform.position.y;
        sren = GetComponent < SpriteRenderer > ();
        offset = (transform.position.x) / depth - mainCamera.transform.position.x;
        
	}

    // Update is called once per frame
    void Update()
    {
        

        Vector3 vehicleposition = new Vector3((mainCamera.transform.position.x + offset) * depth, yPos, zPos);
        transform.position = vehicleposition;

    }
}
