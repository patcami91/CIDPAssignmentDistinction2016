using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public int Coins_points = 0;
    public int HP_points = 0;


    public Text ShowNumCoins;
    public Text ShowNumHP;

    public float horizontal = 0f;
    public float vertical = 0f;

    public AudioClip hourGlass;
    public AudioClip coinPkup;
    public AudioClip HpPkup;
    public AudioClip gameOver;
    public AudioClip DmgPkup;
    public AudioClip gameFinish;


    private Rigidbody rb;
    private AudioSource audio;
    private CanvasController canvasController;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        canvasController = GameObject.FindObjectOfType<CanvasController>();

        Time.timeScale = 1f;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movementKeyboard = new Vector3(moveHorizontal, 0.0f, moveVertical);

        Vector3 movementTouch = new Vector3(horizontal, 0.0f, vertical);

        rb.AddForce(movementKeyboard * speed);
        rb.AddForce(movementTouch * speed);

        ShowNumCoins.text = "Coins: " + Coins_points;
        ShowNumHP.text = "Health: " + HP_points;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DmgDealer")
        {
            
            HP_points -= 10;
            audio.clip = DmgPkup;
            audio.Play();
        }


        if (other.gameObject.tag == "Coin_Pickup")
        {
            Destroy(other.gameObject);
            audio.clip = coinPkup;
            audio.Play();
            Coins_points += 10;
            
           
            

        }

        if (other.gameObject.tag == "HP_Pickup")
        {
            Destroy(other.gameObject);
            audio.clip = HpPkup;
            audio.Play();
            HP_points += 5;

        }

        if (other.gameObject.tag == "deathZone")
        {

            canvasController.Switch("Game Over");
            audio.clip = gameOver;
            audio.Play();
            Time.timeScale = 0f;
          
        }

        if (other.gameObject.tag == "Hr_Glass")
        {
            Destroy(other.gameObject);
            GameObject.FindObjectOfType<Timer>().AdjustStartTime(5f);
            audio.clip = hourGlass;
            audio.Play();
        }

        if (other.gameObject.tag == "Winner")
        {
            audio.clip = gameFinish;
            audio.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 1);

        }

        if (other.gameObject.tag == "ReadyLvls")
        {
            audio.clip = gameFinish;
            audio.Play();
            SceneManager.LoadScene("Menu"); ;

        }
    }
}