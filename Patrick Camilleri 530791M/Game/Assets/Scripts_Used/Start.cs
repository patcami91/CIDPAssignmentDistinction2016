using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("PlayerBall").SendMessage("Start");

    }
}
