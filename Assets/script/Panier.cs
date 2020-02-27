using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panier : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if(other.tag == "PetitObj"){
            score++;
        }
        if(other.tag == "cahier"){
            score = score +3;
        }
        scoreText.text = score.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
