using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Misc : MonoBehaviour {


    public string levelname;
    void Awake()
    {
		QualitySettings.vSyncCount = 0;
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
