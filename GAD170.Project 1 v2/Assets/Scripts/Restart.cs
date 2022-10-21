using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //load scene again if we press SPACE
            Debug.Log("-----------------------");
            Debug.Log("RESTART");
            Debug.Log("-----------------------");
        }
    }
}
