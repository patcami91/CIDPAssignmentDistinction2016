using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("PlayerBall").SendMessage("Finish");

    }
}
