using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreEnabler : MonoBehaviour
{
    public GameObject ScoreObj;
    void Update()
    {
     
        if (GameObject.Find("Player 1") && GameObject.Find("Player 2"))
        {
            ScoreObj.GetComponent<Score>().enabled = true;
        }
    }
}
