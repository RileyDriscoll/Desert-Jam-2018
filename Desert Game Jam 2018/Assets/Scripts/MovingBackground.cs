using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour {

    public float depth;
    public GameObject mainCamera;
    private float zPos;
    private float yPos;

	// Use this for initialization
	void Start () {
        zPos = transform.position.z;
        yPos = transform.position.y;
	}

    // Update is called once per frame
    void Update()
    {

        Vector3 vehicleposition = new Vector3(mainCamera.transform.position.x * depth, yPos, zPos);
        transform.position = vehicleposition;

    }
}
