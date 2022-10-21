using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    
    public GameObject score;

    private void Awake()
    {
        GameObject[] score = GameObject.FindGameObjectsWithTag("Score"); //this code help us to not restart the music after LoadScene
        if (score.Length > 1) //avoid duplicating Music Object
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}