using UnityEngine;
using System.Collections;

public class anim : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*

        //set the trigger when you press space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("start");
        }
        */

    }


    public void startanim()
    {
        
        GetComponent<Animator>().SetTrigger("animatebuttonall");
    }

   

}