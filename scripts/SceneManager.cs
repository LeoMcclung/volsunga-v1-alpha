using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {


    void Update()
    {

    }


    public void LoadLevel (string name)
    {
        Debug.Log("Load level reqest for " + name);
        Application.LoadLevel(name);
    }

	public void QuitRequest()
    {
        Debug.Log("Quit Game Requested");
        Application.Quit();
    }

    public void PauseGame()
    {

    }
}
