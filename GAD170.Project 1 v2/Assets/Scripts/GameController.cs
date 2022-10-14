using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int lHealth = 100;
    public int rHealth = 100;
    public GameObject rPlayer;
    public GameObject lPlayer;
    public GameObject rPWon;
    public GameObject lPWon;
    private int randomGen;
    public Transform lPlayerTransform;
    public float speed = 20.0f;

    public Animator leftDeagle;
    public Animator rightDeagle;
    

    private void Start()
    {
        Debug.Log("Players are connected");
        
        
        
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            lPlayerTransform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            lPlayerTransform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }


        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Debug.Log("Right Player shoots");

            if (Random.Range(0, 100 + 1) <= 25)
            {
                Debug.Log("Right Player MISS!!!");
                Debug.Log("--------------------------------");
            }
            else
            {
                lHealth = lHealth - 20;
                Debug.Log("Health of Left Player is " + lHealth);
                Debug.Log("--------------------------------");
            }

        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("Left Player shoots");
            leftDeagle.Play("LeftDeagle_Shoot");
            if (Random.Range(0, 100 + 1) <= 25)
            {
                Debug.Log("Left Player MISS!!!");
                Debug.Log("--------------------------------");
            }
            else
            {
                rHealth = rHealth - 20;
                Debug.Log("Health of Right Player is " + rHealth);
                Debug.Log("--------------------------------");
            }

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
