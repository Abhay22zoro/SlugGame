using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScorePerSecond : MonoBehaviour
{
    public Text ScoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond; 
    void Start()
    {
     scoreAmount = 0f;
     pointIncreasedPerSecond = 1f;   
    }

    // Update is called once per frame
    void Update()
    {
       ScoreText.text = (int)scoreAmount + ": Score" ;
       scoreAmount += pointIncreasedPerSecond * Time.deltaTime; 
    }
}
