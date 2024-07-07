using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class FinishLine : MonoBehaviour
{

[SerializeField] float finishDelay = 1f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Invoke("ReloadScene", finishDelay);
            //Debug.Log("you finished!");
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
