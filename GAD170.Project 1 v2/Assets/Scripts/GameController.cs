using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

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

    //public Animator leftDeagle;
    public GameObject rightDeagle;
    public GameObject leftDeagle;

    public AudioSource lShot;
    public AudioSource rShot;

    private void Start()
    {
        Debug.Log("Players are connected");
        
        
        
    }
    private void Update()
    {
        /*
        if (Input.GetKey(KeyCode.D))
        {
            lPlayerTransform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            lPlayerTransform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        */

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Debug.Log("Right Player shoots");
            rShot.Play();
            rightDeagle.GetComponent<Animator>().Play("RDeagle_Shoots");
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
            lShot.Play();
            leftDeagle.GetComponent<Animator>().Play("LDeagle_Shoots");
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
            Destroy(rightDeagle);
            lPWon.SetActive(true);
            Destroy(this);
            
        }

        if (lHealth == 0)
        {
            Debug.Log("Left player is dead!");
            Destroy(lPlayer);
            Destroy(leftDeagle);
            rPWon.SetActive(true);
            Destroy(this);
            
        }
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("-----------------------");
        Debug.Log("RESTART");
        Debug.Log("-----------------------");
        } */
    }

   /* public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("-----------------------");
        Debug.Log("RESTART");
        Debug.Log("-----------------------");
    } */
}
