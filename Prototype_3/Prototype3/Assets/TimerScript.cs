using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour

{

    public Text TimerText;
    public float startTime;
    public float t;

    public AudioClip music;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        GetComponent<AudioSource>().clip = music;
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.time - startTime;
        string seconds = t.ToString("f0");
        TimerText.text = seconds;

        
    }
}
