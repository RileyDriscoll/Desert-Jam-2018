using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Misc : MonoBehaviour {


    public string levelname;
    void Awake()
    {
<<<<<<< HEAD
        QualitySettings.vSyncCount = 0;  // VSync must be disabled
=======
		QualitySettings.vSyncCount = 0;
>>>>>>> df422260713d5000c4c7200c5fc98452b951370c
        Application.targetFrameRate = 60;
    }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(levelname);
        }
    }
}
