using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider timer;
    public float timeLeft = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timer.value = timeLeft / 20.0f;
        if(timeLeft < 0)
        {
            Debug.Log("fin timer");
        }
    }
}
