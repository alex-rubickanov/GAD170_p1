using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int lHealth = 100;
    public int rHealth = 100;
    public GameObject rPlayer;
    public GameObject lPlayer;
    public GameObject rPWon;
    public GameObject lPWon;

    private void Start()
    {
        Debug.Log("Players are connected");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("Left Player shoots");
            rHealth = rHealth - 20;
            Debug.Log("Health of Right Player is " + rHealth);
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Debug.Log("Right Player shoots");
            lHealth = lHealth - 20;
            Debug.Log("Health of Left Player is " + lHealth);
        }

        if (rHealth == 0)
        {
            Debug.Log("Right player is dead!");
            Destroy(rPlayer);
            lPWon.SetActive(true);
            Destroy(this);
            
        }

        if (lHealth == 0)
        {
            Debug.Log("Left player is dead!");
            Destroy(lPlayer);
            rPWon.SetActive(true);
            Destroy(this);
            
        }
    }
}
