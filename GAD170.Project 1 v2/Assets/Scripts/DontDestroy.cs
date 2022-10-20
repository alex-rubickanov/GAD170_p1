using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject backMusic;

    private void Awake()
    {
        GameObject[] backMusic = GameObject.FindGameObjectsWithTag("Music");
        if (backMusic.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}