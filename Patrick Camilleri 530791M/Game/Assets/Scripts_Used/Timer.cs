using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float startTime;
    private bool finished = false;
    private bool started = false;

    // Use this for initialization
    void SetTime () {

        startTime = Time.time;

     }
	
	// Update is called once per frame
	void Update () {

        
        if (finished)
            return;

        if (started)
        {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
        }

    }

    void OnTriggerEnter (Collider other)
    {

        if (other.tag == "startTimer")
        {
            startTime = Time.time;
            started = true;
        }

    }

    public void Finish()
    {
        finished = true;
        timerText.color = Color.yellow;

    }

    public void AdjustStartTime (float amount)
    {
        startTime += amount;
    }
}
