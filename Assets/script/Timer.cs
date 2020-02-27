using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider timer;
    public float timeLeft = 20.0f;
    public int score;
    public AudioSource audioDefaite;
    public AudioSource audioVictoire;
    public AudioSource audioTictac;
    public AudioSource fondSonore;
    // Start is called before the first frame update
    void Start()
    {
        fondSonore.Stop();
        audioTictac.Play();
    }
     
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timer.value = timeLeft / 20.0f;
        if(timeLeft < 0)
        {
            if (score >= 20)
            {
                audioVictoire.Play();
            }
            else
            {
                audioDefaite.Play();
            }
            audioTictac.Pause();
            fondSonore.Play();
            Debug.Log("fin timer");
            Destroy(this);
        }
    }
}
