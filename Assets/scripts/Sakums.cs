using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sakums : MonoBehaviour {


    public void apturet()
    {
        Application.Quit();
    }

    public void uzScene()
    {
        SceneManager.LoadScene("izvele", LoadSceneMode.Single);
    }
}
