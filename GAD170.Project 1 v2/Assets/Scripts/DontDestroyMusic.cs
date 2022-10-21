using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    public GameObject backMusic;
    

    private void Awake()
    {
        GameObject[] backMusic = GameObject.FindGameObjectsWithTag("Music"); //this code help us to not restart the music after LoadScene
        if (backMusic.Length > 1) //avoid duplicating Music Object
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

        
    }
}