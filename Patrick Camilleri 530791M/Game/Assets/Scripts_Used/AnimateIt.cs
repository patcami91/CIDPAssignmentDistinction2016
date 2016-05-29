using UnityEngine;
using System.Collections;

public class AnimateIt : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update() { }
    

        public void ButtonPressed()
    {
        GetComponent<Animator>().SetTrigger("menuanimation");
    }

}


