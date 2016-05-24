using UnityEngine;
using System.Collections;

public class MouseDrivenController_Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    //if the game has been running longer than length of game

    float mouseX;

    //mouse position
    mouseX = Input.mousePosition.x;



    Vector3 platePosition;

    platePosition = Camera.main.ScreenToWorldPoint(
        new Vector3(mouseX, 0, 0));

    Debug.Log(platePosition);

    //to keep the y position of the plate, we only use the X
    transform.position =
        new Vector3(platePosition.x, transform.position.y, 0);


}
}
