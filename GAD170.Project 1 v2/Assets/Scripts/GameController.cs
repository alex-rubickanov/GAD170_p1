using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    
    public GameObject rightDeagle;
    public GameObject leftDeagle;

    public AudioSource lShot;
    public AudioSource rShot;

    public GameObject score;



    private void Start()
    {
        Debug.Log("Players are connected");
        score.GetComponent<Score>().enabled = true;


    }
    private void Update()
    {
        if (rPlayer != null)
        {
            if (Input.GetKeyDown(KeyCode.RightShift)) //make right player shoot using Left Shift
            {
                Debug.Log("Right Player shoots");
                rShot.Play();   //play sound of shot
                rightDeagle.GetComponent<Animator>().Play("RDeagle_Shoots"); //play animate of gun
                if (Random.Range(0, 100 + 1) <= 25)
                {
                    Debug.Log("Right Player MISS!!!");      //25% chance to miss
                    Debug.Log("--------------------------------");
                }
                else
                {
                    lHealth = lHealth - 20;
                    Debug.Log("Health of Left Player is " + lHealth); //if player hid - we take
                    Debug.Log("--------------------------------");
                }

            }
        }

        if (lPlayer != null)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))    //make left player shoot using Left Shift
            {
                Debug.Log("Left Player shoots");
                lShot.Play();   //play sound of shot
                leftDeagle.GetComponent<Animator>().Play("LDeagle_Shoots"); //play animate of gun
                if (Random.Range(0, 100 + 1) <= 25)
                {
                    Debug.Log("Left Player MISS!!!");
                    Debug.Log("--------------------------------"); //25% chance to miss
                }
                else
                {
                    rHealth = rHealth - 20;
                    Debug.Log("Health of Right Player is " + rHealth);  //took hp if player got hit
                    Debug.Log("--------------------------------");
                }

            }
        }
        if ((rPlayer != null) && (lPlayer != null))
        {

            if (rHealth == 0)
            {
                Debug.Log("Right player is dead!"); //if right player dies we destroy his model, model of gun, show an UI element that gives players know who win and destroy code to stop the game


                {
                    Destroy(rPlayer);
                    Destroy(rightDeagle);
                    lPWon.SetActive(true);
                    Destroy(this);
                }
            }
        }
        if ((rPlayer != null) && (lPlayer != null))
        {
            if (lHealth == 0)
            {
                Debug.Log("Left player is dead!"); //if right player dies we destroy his model, model of gun, show an UI element that gives players know who win and destroy code to stop the game

                Destroy(lPlayer);
                Destroy(leftDeagle);
                rPWon.SetActive(true);
                Destroy(this);

            }
        }
    }
}
