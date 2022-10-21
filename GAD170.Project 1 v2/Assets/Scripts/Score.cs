using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text lScore;
    public Text rScore;
    public int lScoreCounter = 0;
    public int rScoreCounter = 0;

    //public Behaviour scoreScript;
    
   

    private void Update()
    {
        if (!GameObject.Find("Player 1")) 
        {
            rScoreCounter++;
            rScore.text = rScoreCounter.ToString();
            Debug.Log("Right Score +1");
            this.enabled = false;
        }

        if (!GameObject.Find("Player 2"))
        {
            lScoreCounter++;
            lScore.text = lScoreCounter.ToString();
            Debug.Log("Left Score +1");
            this.enabled = false;
        }
        
    }
    


}
