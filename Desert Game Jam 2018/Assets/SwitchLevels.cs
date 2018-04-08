using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevels : MonoBehaviour {

    private AssetBundle myLoadedAssetBundle;
    public string sceneToLoad;

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
