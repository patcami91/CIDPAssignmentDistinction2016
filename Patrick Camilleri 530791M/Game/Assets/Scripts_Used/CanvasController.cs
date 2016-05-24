using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CanvasController : MonoBehaviour {

    public GameObject[] canvases;
    public string defaultEnabled;

    void Start ()
    {

        Switch(defaultEnabled);

    }

    public void Switch (string name)
    {
        foreach (GameObject go in canvases)
        {
            go.SetActive(name == go.name);
        }
    }

    public void PlayAgain (int level)
    {
        SceneManager.LoadScene(level);
    }
	
}
