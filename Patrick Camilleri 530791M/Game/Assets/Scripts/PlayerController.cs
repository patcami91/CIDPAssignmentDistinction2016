using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public int Coins_points = 0;
    public int HP_points = 0;
    public int Timer = 0;

    public Text ShowNumCoins;
    public Text ShowNumHP;
    public Text ShowTimer;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
   }

    void FixedUpdate()
    {  
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
		
		ShowNumCoins.text ="Coins: " + Coins_points;
        ShowNumHP.text = "Health: " + HP_points;
        ShowTimer.text = "Time: " + Timer;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin_Pickup")
         {
            Destroy(other.gameObject);
            Coins_points++;
         }
  
        if (other.gameObject.tag == "HP_Pickup")
        {
            Destroy(other.gameObject);
            HP_points++;
        }
    }


}
