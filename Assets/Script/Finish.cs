using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public string LevelName;

    
    void Start()
    {

    }
        void OnTriggerEnter(Collider collider)
        {

            if (collider.gameObject.tag == "Player")
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
}