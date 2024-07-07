using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

[SerializeField] float crashDelay = 0.5f;

void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "ground")
        {
            //Debug.Log("you bumped your head");
            Invoke("ReloadScene", crashDelay);
        }
    }


void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
